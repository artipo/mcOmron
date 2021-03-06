﻿using System;
using System.Net;
using System.Text;

namespace mcOMRON
{
	/// <summary>
	/// 
	/// Version:	1.0
	/// Author:		Joan Magnet
	/// Date:		02/2015
	/// 
	/// FINS command object
	/// 
	/// Implemented FINS commands:
	/// 
	/// - MEMORY AREA READ
	/// - MEMORY AREA WRITE
	/// - CONNECTION DATA READ
	/// 
	/// </summary>
	public class udpFINSCommand : IFINSCommand
	{
		#region **** properties

		/// <summary>
		/// return the connection status
		/// </summary>
		public bool Connected
		{
			get { return this._transport.Connected; }
		}


		/// <summary>
		/// return last error detected
		/// </summary>
		public string LastError
		{
			get { return this._lastError; }
		}


		/// <summary>
		/// transport layer
		/// </summary>
		public mcOMRON.ITransport Transport
		{
			get { return this._transport; }
		}


		/// <summary>
		/// return the last FINS response
		/// </summary>
		public Byte [] Response
		{
			get { return this.respFinsData; }
		}



		#region **** FINS Command's fields

		/// <summary>
		/// ICF Information control field
		/// </summary>
		public Byte ICF
		{
			get { return this.cmdFins[0]; }
			set { this.cmdFins[0] = value; }
		}

		/// <summary>
		/// RSC Reserved 
		/// </summary>
		public Byte RSC
		{
			get { return this.cmdFins[1]; }
			set { this.cmdFins[1] = value; }
		}


		/// <summary>
		/// GTC Gateway count
		/// </summary>
		public Byte GTC
		{
			get { return this.cmdFins[2]; }
			set { this.cmdFins[2] = value; }
		}


		/// <summary>
		/// DNA Destination network address (0=local network)
		/// </summary>
		public Byte DNA
		{
			get { return this.cmdFins[3]; }
			set { this.cmdFins[3] = value; }
		}


		/// <summary>
		/// DA1 Destination node number
		/// </summary>
		public Byte DA1
		{
			get { return this.cmdFins[4]; }
			set { this.cmdFins[4] = value; }
		}


		/// <summary>
		/// DA2 Destination unit address
		/// </summary>
		public Byte DA2
		{
			get { return this.cmdFins[5]; }
			set { this.cmdFins[5] = value; }
		}


		/// <summary>
		/// SNA Source network address (0=local network)
		/// </summary>
		public Byte SNA
		{
			get { return this.cmdFins[6]; }
			set { this.cmdFins[6] = value; }
		}


		/// <summary>
		/// SA1 Source node number
		/// </summary>
		public Byte SA1
		{
			get { return this.cmdFins[7]; }
			set { this.cmdFins[7] = value; }
		}


		/// <summary>
		/// SA2 Source unit address
		/// </summary>
		public Byte SA2
		{
			get { return this.cmdFins[8]; }
			set { this.cmdFins[8] = value; }
		}


		/// <summary>
		/// SID Service ID
		/// </summary>
		public Byte SID
		{
			get { return this.cmdFins[9]; }
			set { this.cmdFins[9] = value; }
		}


		/// <summary>
		/// MC Main command
		/// </summary>
		public Byte MC
		{
			get { return this.cmdFins[10]; }
			set { this.cmdFins[10] = value; }
		}


		/// <summary>
		/// SC Subcommand
		/// </summary>
		public Byte SC
		{
			get { return this.cmdFins[11]; }
			set { this.cmdFins[11] = value; }
		}
		
		#endregion
		

		
		#region **** frame send command & response fields

		/// <summary>
		/// FRAME SEND response main code error
		/// </summary>
		public Byte FSR_MER
		{
			get { return respFins[12]; }
		}


		/// <summary>
		/// FRAME SEND response subcode error
		/// </summary>
		public Byte FSR_SER
		{
			get { return respFins[13]; }
		}
		
		#endregion

		#endregion



		#region **** constructor
		
		/// <summary>
		/// constructor, by default SID=0x01
		/// </summary>
		/// <param name="transportLayer"></param>
		/// <param name="ServiceID"></param>
		public udpFINSCommand(Byte ServiceID=0x01)
		{
			// transport layer
			//
			this._transport = new mcOMRON.udpTransport();

			// Default fins command fields
			//
			this.SID = ServiceID;
		} 


		/// <summary>
		/// set ip and port
		/// </summary>
		/// <param name="ip"></param>
		/// <param name="port"></param>
		public void SetUDPParams(IPAddress ip, int port, int sa1, int da1)
		{
			this.DA1 = Convert.ToByte(da1);
			this.SA1 = Convert.ToByte(sa1);
			
			this._transport.SetUDPParams(ip, port);
		}

		#endregion



		#region **** connect & close
		
		/// <summary>
		/// open the connection
		/// </summary>
		/// <returns></returns>
		public bool Connect()
		{
			try
			{
				return this._transport.Connect();
			}
			catch (Exception ex)
			{

				this._lastError = ex.Message;
				return false;
			}
		}


		/// <summary>
		/// close the connection
		/// </summary>
		public void Close()
		{
			this._transport.Close();
		} 

		#endregion



		#region **** methods

		#region **** implemented fins commands

		/// <summary>
		/// MEMORY AREA READ
		/// </summary>
		/// <param name="area"></param>
		/// <param name="address"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public bool MemoryAreaRead(MemoryArea area, UInt16 address, Byte bit_position, UInt16 count)
		{
			try
			{
				// command & subcomand
				//
				this.MC = 0x01;
				this.SC = 0x01;

				// memory area
				//
				this.cmdFins[F_PARAM] = (Byte)area;

				// address
				//
				this.cmdFins[F_PARAM + 1] = (Byte)((address >> 8) & 0xFF);
				this.cmdFins[F_PARAM + 2] = (Byte)(address & 0xFF);

				// no bit position
				//
				this.cmdFins[F_PARAM + 3] = bit_position;

				// count items
				//
				this.cmdFins[F_PARAM + 4] = (Byte)((count >> 8) & 0xFF);
				this.cmdFins[F_PARAM + 5] = (Byte)(count & 0xFF);

				// set command lenght (12 + additional params)
				//
				this.finsCommandLen = 18;
				
				// set response lenght (14 + data)
				//
				this.finsResponseLen = Convert.ToUInt16(14 + count * 2);

				// send the message
				//
				return FrameSend(null);
			}
			catch (Exception ex)
			{
				this._lastError = ex.Message;
				return false;
			}
		}
		

		/// <summary>
		/// MEMORY AREA WRITE
		/// </summary>
		/// <param name="area"></param>
		/// <param name="address"></param>
		/// <param name="count"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public bool MemoryAreaWrite(MemoryArea area, UInt16 address, Byte bit_position, UInt16 count, ref Byte[] data)
		{
			try
			{
				// command & subcomand
				//
				this.MC = 0x01;
				this.SC = 0x02;

				// memory area
				//
				this.cmdFins[F_PARAM] = (Byte)area;

				// address
				//
				this.cmdFins[F_PARAM + 1] = (Byte)((address >> 8) & 0xFF);
				this.cmdFins[F_PARAM + 2] = (Byte)(address & 0xFF);

				// bit position
				//
				this.cmdFins[F_PARAM + 3] = bit_position;

				// count items
				//
				this.cmdFins[F_PARAM + 4] = (Byte)((count >> 8) & 0xFF);
				this.cmdFins[F_PARAM + 5] = (Byte)(count & 0xFF);

				// set command lenght (12 + additional params)
				//
				this.finsCommandLen = 18;
				
				// set response lenght (14 + data)
				//
				this.finsResponseLen = 14;

				// send the message
				//
				return FrameSend(data);
			}
			catch (Exception ex)
			{
				this._lastError = ex.Message;
				return false;
			}
		}
		

		/// <summary>
		/// CONNECTION DATA READ
		/// </summary>
		/// <param name="area"></param>
		/// <returns></returns>
		public bool ConnectionDataRead(Byte area)
		{
			try
			{
				// command & subcomand
				//
				this.MC = 0x05;
				this.SC = 0x01;

				// memory area
				//
				this.cmdFins[F_PARAM] = (Byte)area;

				// set command lenght (12 + additional params)
				//
				this.finsCommandLen = 13;

				// set response lenght (14 + data)
				//
				if (area == 0)
				{
					this.finsResponseLen = Convert.ToUInt16(14 + 92);
				}
				else if (area == 1)
				{
					this.finsResponseLen = Convert.ToUInt16(14 + 66);
				}
				else
				{
					this.finsResponseLen = Convert.ToUInt16(14 + 158);
				}
				
				return FrameSend(null);
			}
			catch (Exception ex)
			{
				this._lastError = ex.Message;
				return false;
			}
		} 
		
		#endregion


		#region **** frame send

		/// <summary>
		/// FRAME SEND
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		private bool FrameSend(Byte[] data)
		{
			// send FINS command
			//
			this.Transport.Send(ref this.cmdFins, this.finsCommandLen);


			// send additional data
			//
			if (data != null)
			{
				this.Transport.Send(ref data, data.Length);
			}


			// fins command response
			//
			this.Transport.Receive(ref this.respFins, this.finsResponseLen);

			
			if (finsResponseLen > 14)
			{
				for (int x = 0; x < this.finsResponseLen - 14; x++)
				{
					this.respFinsData[x] = this.respFins[x + 14];
				}
			}


			// check response code
			//
			if (this.FSR_MER != 0 || this.FSR_SER != 0)
			{
				this._lastError += string.Format("Response Code error: (Code: {0}  Subcode: {1})",
													this.FSR_MER, this.FSR_SER);
				return false;
			}

			return true;
		}
		
		#endregion

		#endregion



		#region **** debug dialog
		
		/// <summary>
		/// return last dialog between pc and plc
		/// </summary>
		/// <param name="Caption"></param>
		/// <returns></returns>
		public string LastDialog(string Caption)
		{
			StringBuilder dialog = new StringBuilder(Caption + Environment.NewLine);
			dialog.Append(Environment.NewLine);
			dialog.Append("FINS COMMAND" + Environment.NewLine);
			dialog.Append(BitConverter.ToString(this.cmdFins,0,finsCommandLen) + Environment.NewLine);
			dialog.Append("FINS RESPONSE" + Environment.NewLine);
			dialog.Append(BitConverter.ToString(this.respFins, 0, 14) + Environment.NewLine);
			dialog.Append("FINS DATA" + Environment.NewLine);
			dialog.Append(BitConverter.ToString(this.respFinsData, 0, finsResponseLen-14) + Environment.NewLine);
			dialog.Append("Last error: " + this._lastError + Environment.NewLine);
			dialog.Append(Environment.NewLine);

			return dialog.ToString();
		}

		#endregion		
		


		#region **** variables

		// last detected error
		//
		private string _lastError = "";


		// TCP transport layer
		//
		mcOMRON.udpTransport _transport = null;


		// FINS RESPONSE (command)
		//
		Byte[] respFins = new Byte[2048];
		
		// FINS RESPONSE (data, 2KB reserved memory)
		//
		Byte[] respFinsData = new Byte[2048];


		// response data length
		//
		UInt16 finsResponseLen = 0;


		/// <summary>
		/// FINS COMMAND (2KB reserved memory)
		/// </summary>
		Byte[] cmdFins = new Byte[]
		{
			//---- COMMAND HEADER -------------------------------------------------------
			0x80,				// 00 ICF Information control field 
			0x00,				// 01 RSC Reserved 
			0x02,				// 02 GTC Gateway count
			0x00,				// 03 DNA Destination network address (0=local network)
			0x00,				// 04 DA1 Destination node number
			0x00,				// 05 DA2 Destination unit address
			0x00,				// 06 SNA Source network address (0=local network)
			0x00,				// 07 SA1 Source node number
			0x00,				// 08 SA2 Source unit address
			0x00,				// 09 SID Service ID
			//---- COMMAND --------------------------------------------------------------
			0x00,				// 10 MC Main command
			0x00,				// 11 SC Subcommand
			//---- PARAMS ---------------------------------------------------------------
			0x00,				// 12 reserved area for additional params
			0x00,				// depending on fins command
			0x00,
			0x00,
			0x00,
			0x00,
			0x00,
			0x00,
			0x00,
			0x00,
		};
		
		// command length
		//
		UInt16 finsCommandLen = 0;

		/// <summary>
		/// first position of PARAM area in the fins command
		/// </summary>
		const int F_PARAM = 12;

		#endregion	
	}
}
 