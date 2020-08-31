using mcOMRON;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace test_plc
{
	public partial class TestPLC : Form
	{
		// plc object
		//
		mcOMRON.OmronPLC plc;

		/// <summary>
		/// constructor
		/// </summary>
		public TestPLC()
		{
			InitializeComponent();

			InitDataSources();
		}

		
		#region **** init data sources

		
		private void InitDataSources()
		{
			InitProtocolDataSource();
			InitWordMemoryAreaDataSource();
			InitBitMemoryAreaDataSource();
		}

		
		private void InitProtocolDataSource()
		{
			var protocols = Enum.GetValues(typeof(mcOMRON.TransportType));

			transport_type.DataSource = protocols;
			transport_type.SelectedItem = mcOMRON.TransportType.Tcp;
		}

		
		private void InitWordMemoryAreaDataSource()
		{
			MemoryArea[] memoryAreas = new[]
			{
				MemoryArea.CIO,
				MemoryArea.WR,
				MemoryArea.HR,
				MemoryArea.AR,
				MemoryArea.TIM,
				MemoryArea.CNT,
				MemoryArea.CNT,
				MemoryArea.DM,
				MemoryArea.TK
			};
			
			word_memory_area.DataSource = memoryAreas;
			word_memory_area.SelectedItem = MemoryArea.DM;
		}
		
		
		private void InitBitMemoryAreaDataSource()
		{
			MemoryArea[] memoryAreas = new[]
			{
				MemoryArea.CIO_Bit,
				MemoryArea.WR_Bit,
				MemoryArea.HR_Bit,
				MemoryArea.AR_Bit,
				MemoryArea.DM_Bit,
				MemoryArea.TK_Bit
			};
			
			bit_memory_area.DataSource = memoryAreas;
			bit_memory_area.SelectedItem = MemoryArea.DM_Bit;
		}

		
		#endregion
		
		
		/// <summary>
		/// try to connect to the plc
		/// </summary>
		private void Connect()
		{
			if (string.IsNullOrWhiteSpace(ip.Text) || string.IsNullOrWhiteSpace(port.Text))
				return;

			try
			{
				mcOMRON.TransportType protocol = (mcOMRON.TransportType) transport_type.SelectedItem;
				plc = new OmronPLC(protocol);
				
				IPAddress ipAddress = IPAddress.Parse(ip.Text);
				int port = Convert.ToInt32(this.port.Text);
				
				switch(protocol)
				{
					case mcOMRON.TransportType.Tcp:
						tcpFINSCommand tcpFinsCommand = (tcpFINSCommand) plc.FinsCommand;
						tcpFinsCommand.SetTCPParams(ipAddress, port);
						break;

					case mcOMRON.TransportType.Udp:
						if (string.IsNullOrWhiteSpace(source_node.Text) || string.IsNullOrWhiteSpace(destination_node.Text))
							return;

						int sa1 = Convert.ToInt32(source_node.Text);
						int da1 = Convert.ToInt32(destination_node.Text);
						
						udpFINSCommand udpFinsCommand = (udpFINSCommand) plc.FinsCommand;
						udpFinsCommand.SetUdpParams(ipAddress, port, sa1, da1);
						
						break;
				}

				// connection
				//
				if (! plc.Connect())
				{
					throw new Exception(plc.LastError);
				}

				if (protocol == mcOMRON.TransportType.Tcp)
				{
					tcpFINSCommand tcpFinsCommand = (tcpFINSCommand) plc.FinsCommand;
					
					destination_node.Text = tcpFinsCommand.DA1.ToString();
					source_node.Text = tcpFinsCommand.SA1.ToString();
				}

				// set UI
				//
				bt_connect.Enabled = false;
				ip.Enabled = false;
				this.port.Enabled = false;
				destination_node.Enabled = false;
				source_node.Enabled = false;
				transport_type.Enabled = false;
				bt_close.Enabled = true;
				bt_connection_data_read.Enabled = true;
				groupWord.Enabled = true;
				groupBit.Enabled = true;
				groupDialogText.Enabled = true;
				dialog.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Connect() error: " + ex.Message);
			}
		}
		

		/// <summary>
		/// shutdown the connection
		/// </summary>
		private void Shutdown()
		{
			plc.Close();
			plc = null;

			bt_connect.Enabled = true;
			ip.Enabled = true;
			port.Enabled = true;
			transport_type.Enabled = true;
			bt_close.Enabled = false;
			bt_connection_data_read.Enabled = false;
			groupWord.Enabled = false;
			groupBit.Enabled = false;
			groupDialogText.Enabled = false;

			UpdateNodesEnabled();
		}
		

		/// <summary>
		/// exits this application
		/// </summary>
		private void Exit()
		{
			plc.Close();
			this.Close();
		}


		/// <summary>
		/// read a word
		/// </summary>
		private void ReadWord()
		{
			if (string.IsNullOrWhiteSpace(word_position.Text) ||
			    string.IsNullOrWhiteSpace(word_count.Text))
				return;
			
			UInt16 val = 0;

			try
			{
				MemoryArea area = (MemoryArea) word_memory_area.SelectedItem;
				UInt16 position = Convert.ToUInt16(word_position.Text);
				UInt16 count = Convert.ToUInt16(word_count.Text);

				if (! plc.finsMemoryAreadRead(area, position, 0, count))
				{
					throw new Exception(plc.LastError);
				}

				val = BTool.BytesToUInt16(plc.FinsCommand.Response[0], plc.FinsCommand.Response[1]);

				word_value.Text = val.ToString();

				dialog.Text = plc.LastDialog("READ WORD");
				dialog.AppendText("WORD VALUE: " + val.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("ReadWord() Error: " + ex.Message);
			}
		}


		/// <summary>
		/// read a single bit
		/// </summary>
		private void ReadBit()
		{
			if (string.IsNullOrWhiteSpace(bit_position.Text) ||
			    string.IsNullOrWhiteSpace(bit_bit_position.Text)) return;

			bool bitval;

			try
			{
				MemoryArea area = (MemoryArea) bit_memory_area.SelectedItem;
				UInt16 position = Convert.ToUInt16(bit_position.Text);
				byte bitpos = Convert.ToByte(bit_bit_position.Text);
				

				if (! plc.finsMemoryAreadRead(area, position, bitpos, 1))
				{
					throw new Exception(plc.LastError);
				}

				bitval = Convert.ToBoolean(plc.FinsCommand.Response[0]);

				bit_value.Checked = bitval;

				dialog.Text = plc.LastDialog("READ BIT");
				dialog.AppendText("BIT VALUE: " + bitval.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("ReadBit() error: " + ex.Message);
			}
		}


		/// <summary>
		/// Controller data read
		/// </summary>
		private void ControllerDataRead()
		{
			try
			{
				if (!plc.finsConnectionDataRead(0))
				{
					throw new Exception(plc.LastError);
				}

				dialog.Text = plc.LastDialog("CONTROLLER DATA READ");
				dialog.AppendText("CONTROLLER: " + Encoding.ASCII.GetString(plc.FinsCommand.Response, 0, 20));
				dialog.AppendText(Environment.NewLine);
				dialog.AppendText("VERSION: " + Encoding.ASCII.GetString(plc.FinsCommand.Response, 20, 20));
			}
			catch (Exception ex)
			{
				MessageBox.Show("ControllerDataRead() error: " + ex.Message);
			}
		}


		/// <summary>
		/// write a single word
		/// </summary>
		private void WriteWord()
		{
			if (string.IsNullOrWhiteSpace(word_position.Text) ||
			    string.IsNullOrWhiteSpace(word_count.Text))
				return;
			
			UInt16 val = 0;

			try
			{
				val = Convert.ToUInt16(word_value.Text);

				if (MessageBox.Show("This action will write some memory area of your PLC.\n\nContinue anyway?"
								, "OMRON PLC text"
								, MessageBoxButtons.OKCancel
								, MessageBoxIcon.Question
								, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
				{
					return;
				}

				var area = (MemoryArea) word_memory_area.SelectedItem;
				var position = Convert.ToUInt16(word_position.Text);
				var count = Convert.ToUInt16(word_count.Text);
				var data = BTool.Uint16toBytes(val);
				
				if (count > 1)
					return;

				if (! plc.finsMemoryAreadWrite(area, position, 0, 1, data))
				{
					throw new Exception(plc.LastError);
				}

				dialog.Text = plc.LastDialog("WRITE WORD");
			}
			catch (Exception ex)
			{
				MessageBox.Show("WriteWord() error: " + ex.Message);
			}
		}


		/// <summary>
		/// clear a single bit
		/// </summary>
		private void ClearBit()
		{
			if (string.IsNullOrWhiteSpace(bit_position.Text) ||
			    string.IsNullOrWhiteSpace(bit_bit_position.Text)) return;

			try
			{
				MemoryArea area = (MemoryArea) bit_memory_area.SelectedItem;
				UInt16 position = Convert.ToUInt16(bit_position.Text);
				byte bitpos = Convert.ToByte(bit_bit_position.Text);
				

				if (! plc.finsMemoryAreadWrite(area, position, bitpos, 1, new []{(byte) 0}))
				{
					throw new Exception(plc.LastError);
				}

				dialog.Text = plc.LastDialog("CLEAR BIT");
			}
			catch (Exception ex)
			{
				MessageBox.Show("ReadBit() error: " + ex.Message);
			}
		}
		
		
		/// <summary>
		/// raise a single bit
		/// </summary>
		private void RaiseBit()
		{
			if (string.IsNullOrWhiteSpace(bit_position.Text) ||
			    string.IsNullOrWhiteSpace(bit_bit_position.Text)) return;

			try
			{
				MemoryArea area = (MemoryArea) bit_memory_area.SelectedItem;
				UInt16 position = Convert.ToUInt16(bit_position.Text);
				byte bitpos = Convert.ToByte(bit_bit_position.Text);
				

				if (! plc.finsMemoryAreadWrite(area, position, bitpos, 1, new []{(byte) 1}))
				{
					throw new Exception(plc.LastError);
				}

				dialog.Text = plc.LastDialog("RAISE BIT");
			}
			catch (Exception ex)
			{
				MessageBox.Show("ReadBit() error: " + ex.Message);
			}
		}


		private void UpdateNodesEnabled()
        {
			if (plc != null && plc.Connected)
				return;

			mcOMRON.TransportType transportType = (mcOMRON.TransportType)transport_type.SelectedItem;

			if (transportType == mcOMRON.TransportType.Tcp)
			{
				destination_node.Enabled = false;
				source_node.Enabled = false;
			}
			else
            {
				destination_node.Enabled = true;
				source_node.Enabled = true;
			}
		}
		

		#region **** controls events
		
		private void bt_connect_Click(object sender, EventArgs e)
		{
			Connect();
		}

		private void bt_close_Click(object sender, EventArgs e)
		{
			Shutdown();
		}

		private void bt_exit_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void bt_read_word_Click(object sender, EventArgs e)
		{
			ReadWord();
		}

		private void bt_write_word_Click(object sender, EventArgs e)
		{
			WriteWord();
		}

		private void bt_read_bit_Click(object sender, EventArgs e)
		{
			ReadBit();
		}

		private void bt_clear_bit_Click(object sender, EventArgs e)
		{
			ClearBit();
		}
		
		private void bt_raise_bit_Click(object sender, EventArgs e)
		{
			RaiseBit();
		}

		private void bt_connection_data_read_Click(object sender, EventArgs e)
		{
			ControllerDataRead();
		}

		private void transport_type_SelectionChangeCommitted(object sender, EventArgs e)
		{
			UpdateNodesEnabled();
		}

		#endregion
	}
}
