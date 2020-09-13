using System;

namespace test_plc
{
	partial class TestPLC
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.left_panel = new System.Windows.Forms.Panel();
            this.groupBit = new System.Windows.Forms.GroupBox();
            this.bit_value = new System.Windows.Forms.CheckBox();
            this.bt_raise_bit = new System.Windows.Forms.Button();
            this.bit_bit_position = new System.Windows.Forms.TextBox();
            this.bit_memory_area = new System.Windows.Forms.ComboBox();
            this.bt_clear_bit = new System.Windows.Forms.Button();
            this.bt_read_bit = new System.Windows.Forms.Button();
            this.bit_position = new System.Windows.Forms.TextBox();
            this.groupWord = new System.Windows.Forms.GroupBox();
            this.word_repetition = new System.Windows.Forms.TextBox();
            this.bt_speed_test = new System.Windows.Forms.Button();
            this.word_count = new System.Windows.Forms.TextBox();
            this.word_memory_area = new System.Windows.Forms.ComboBox();
            this.bt_write_word = new System.Windows.Forms.Button();
            this.word_value = new System.Windows.Forms.TextBox();
            this.bt_read_word = new System.Windows.Forms.Button();
            this.word_position = new System.Windows.Forms.TextBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transport_type = new System.Windows.Forms.ComboBox();
            this.destination_node = new System.Windows.Forms.TextBox();
            this.source_node = new System.Windows.Forms.TextBox();
            this.bt_connection_data_read = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.right_panel = new System.Windows.Forms.Panel();
            this.groupDialogText = new System.Windows.Forms.GroupBox();
            this.dialog = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.left_panel.SuspendLayout();
            this.groupBit.SuspendLayout();
            this.groupWord.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.groupDialogText.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(97, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 15);
            label6.TabIndex = 8;
            label6.Text = "Position:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(97, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Port:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "I.P.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(260, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Value:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(7, 29);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(91, 15);
            label10.TabIndex = 13;
            label10.Text = "Memory Area:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(7, 87);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(56, 15);
            label11.TabIndex = 9;
            label11.Text = "Source:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(7, 116);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(91, 15);
            label12.TabIndex = 11;
            label12.Text = "Destination:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(179, 29);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(49, 15);
            label13.TabIndex = 16;
            label13.Text = "Count:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 15);
            label5.TabIndex = 17;
            label5.Text = "Memory Area:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(179, 32);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(63, 15);
            label14.TabIndex = 20;
            label14.Text = "Bit Pos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 145);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(112, 15);
            label7.TabIndex = 13;
            label7.Text = "Transport Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(260, 32);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(49, 15);
            label8.TabIndex = 17;
            label8.Text = "Value:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(7, 108);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 15);
            label9.TabIndex = 20;
            label9.Text = "Repetition:";
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.groupBit);
            this.left_panel.Controls.Add(this.groupWord);
            this.left_panel.Controls.Add(this.bt_exit);
            this.left_panel.Controls.Add(this.groupBox1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Padding = new System.Windows.Forms.Padding(5);
            this.left_panel.Size = new System.Drawing.Size(357, 675);
            this.left_panel.TabIndex = 15;
            // 
            // groupBit
            // 
            this.groupBit.Controls.Add(label8);
            this.groupBit.Controls.Add(this.bit_value);
            this.groupBit.Controls.Add(this.bt_raise_bit);
            this.groupBit.Controls.Add(this.bit_bit_position);
            this.groupBit.Controls.Add(label14);
            this.groupBit.Controls.Add(this.bit_memory_area);
            this.groupBit.Controls.Add(label5);
            this.groupBit.Controls.Add(this.bt_clear_bit);
            this.groupBit.Controls.Add(this.bt_read_bit);
            this.groupBit.Controls.Add(this.bit_position);
            this.groupBit.Controls.Add(label6);
            this.groupBit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBit.Enabled = false;
            this.groupBit.Location = new System.Drawing.Point(5, 458);
            this.groupBit.Name = "groupBit";
            this.groupBit.Size = new System.Drawing.Size(347, 118);
            this.groupBit.TabIndex = 2;
            this.groupBit.TabStop = false;
            this.groupBit.Text = "Bit";
            // 
            // bit_value
            // 
            this.bit_value.AutoSize = true;
            this.bit_value.Location = new System.Drawing.Point(263, 54);
            this.bit_value.Name = "bit_value";
            this.bit_value.Size = new System.Drawing.Size(15, 14);
            this.bit_value.TabIndex = 22;
            this.bit_value.UseVisualStyleBackColor = true;
            // 
            // bt_raise_bit
            // 
            this.bt_raise_bit.Location = new System.Drawing.Point(100, 79);
            this.bt_raise_bit.Name = "bt_raise_bit";
            this.bt_raise_bit.Size = new System.Drawing.Size(75, 23);
            this.bt_raise_bit.TabIndex = 21;
            this.bt_raise_bit.Text = "Raise";
            this.bt_raise_bit.UseVisualStyleBackColor = true;
            this.bt_raise_bit.Click += new System.EventHandler(this.bt_raise_bit_Click);
            // 
            // bit_bit_position
            // 
            this.bit_bit_position.Location = new System.Drawing.Point(182, 50);
            this.bit_bit_position.Name = "bit_bit_position";
            this.bit_bit_position.Size = new System.Drawing.Size(75, 23);
            this.bit_bit_position.TabIndex = 19;
            this.bit_bit_position.Text = "0";
            // 
            // bit_memory_area
            // 
            this.bit_memory_area.FormattingEnabled = true;
            this.bit_memory_area.Location = new System.Drawing.Point(10, 50);
            this.bit_memory_area.Name = "bit_memory_area";
            this.bit_memory_area.Size = new System.Drawing.Size(84, 23);
            this.bit_memory_area.TabIndex = 18;
            // 
            // bt_clear_bit
            // 
            this.bt_clear_bit.Location = new System.Drawing.Point(182, 79);
            this.bt_clear_bit.Name = "bt_clear_bit";
            this.bt_clear_bit.Size = new System.Drawing.Size(75, 23);
            this.bt_clear_bit.TabIndex = 3;
            this.bt_clear_bit.Text = "Clear";
            this.bt_clear_bit.UseVisualStyleBackColor = true;
            this.bt_clear_bit.Click += new System.EventHandler(this.bt_clear_bit_Click);
            // 
            // bt_read_bit
            // 
            this.bt_read_bit.Location = new System.Drawing.Point(10, 79);
            this.bt_read_bit.Name = "bt_read_bit";
            this.bt_read_bit.Size = new System.Drawing.Size(84, 23);
            this.bt_read_bit.TabIndex = 2;
            this.bt_read_bit.Text = "Read";
            this.bt_read_bit.UseVisualStyleBackColor = true;
            this.bt_read_bit.Click += new System.EventHandler(this.bt_read_bit_Click);
            // 
            // bit_position
            // 
            this.bit_position.Location = new System.Drawing.Point(100, 50);
            this.bit_position.Name = "bit_position";
            this.bit_position.Size = new System.Drawing.Size(75, 23);
            this.bit_position.TabIndex = 0;
            this.bit_position.Text = "0";
            // 
            // groupWord
            // 
            this.groupWord.Controls.Add(this.word_repetition);
            this.groupWord.Controls.Add(label9);
            this.groupWord.Controls.Add(this.bt_speed_test);
            this.groupWord.Controls.Add(this.word_count);
            this.groupWord.Controls.Add(label13);
            this.groupWord.Controls.Add(this.word_memory_area);
            this.groupWord.Controls.Add(label10);
            this.groupWord.Controls.Add(this.bt_write_word);
            this.groupWord.Controls.Add(this.word_value);
            this.groupWord.Controls.Add(label4);
            this.groupWord.Controls.Add(this.bt_read_word);
            this.groupWord.Controls.Add(this.word_position);
            this.groupWord.Controls.Add(label3);
            this.groupWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupWord.Enabled = false;
            this.groupWord.Location = new System.Drawing.Point(5, 266);
            this.groupWord.Name = "groupWord";
            this.groupWord.Size = new System.Drawing.Size(347, 192);
            this.groupWord.TabIndex = 1;
            this.groupWord.TabStop = false;
            this.groupWord.Text = "Word";
            // 
            // word_repetition
            // 
            this.word_repetition.Location = new System.Drawing.Point(10, 126);
            this.word_repetition.Name = "word_repetition";
            this.word_repetition.Size = new System.Drawing.Size(75, 23);
            this.word_repetition.TabIndex = 19;
            this.word_repetition.Text = "0";
            // 
            // bt_speed_test
            // 
            this.bt_speed_test.Enabled = false;
            this.bt_speed_test.Location = new System.Drawing.Point(10, 155);
            this.bt_speed_test.Name = "bt_speed_test";
            this.bt_speed_test.Size = new System.Drawing.Size(95, 23);
            this.bt_speed_test.TabIndex = 18;
            this.bt_speed_test.Text = "Speed Test";
            this.bt_speed_test.UseVisualStyleBackColor = true;
            this.bt_speed_test.Click += new System.EventHandler(this.bt_speed_test_Click);
            // 
            // word_count
            // 
            this.word_count.Location = new System.Drawing.Point(182, 47);
            this.word_count.Name = "word_count";
            this.word_count.Size = new System.Drawing.Size(75, 23);
            this.word_count.TabIndex = 15;
            this.word_count.Text = "1";
            // 
            // word_memory_area
            // 
            this.word_memory_area.FormattingEnabled = true;
            this.word_memory_area.Location = new System.Drawing.Point(10, 47);
            this.word_memory_area.Name = "word_memory_area";
            this.word_memory_area.Size = new System.Drawing.Size(84, 23);
            this.word_memory_area.TabIndex = 14;
            // 
            // bt_write_word
            // 
            this.bt_write_word.Location = new System.Drawing.Point(100, 76);
            this.bt_write_word.Name = "bt_write_word";
            this.bt_write_word.Size = new System.Drawing.Size(75, 23);
            this.bt_write_word.TabIndex = 3;
            this.bt_write_word.Text = "Write";
            this.bt_write_word.UseVisualStyleBackColor = true;
            this.bt_write_word.Click += new System.EventHandler(this.bt_write_word_Click);
            // 
            // word_value
            // 
            this.word_value.Location = new System.Drawing.Point(263, 47);
            this.word_value.Name = "word_value";
            this.word_value.Size = new System.Drawing.Size(75, 23);
            this.word_value.TabIndex = 1;
            this.word_value.Text = "0";
            // 
            // bt_read_word
            // 
            this.bt_read_word.Location = new System.Drawing.Point(10, 76);
            this.bt_read_word.Name = "bt_read_word";
            this.bt_read_word.Size = new System.Drawing.Size(84, 23);
            this.bt_read_word.TabIndex = 2;
            this.bt_read_word.Text = "Read";
            this.bt_read_word.UseVisualStyleBackColor = true;
            this.bt_read_word.Click += new System.EventHandler(this.bt_read_word_Click);
            // 
            // word_position
            // 
            this.word_position.Location = new System.Drawing.Point(100, 47);
            this.word_position.Name = "word_position";
            this.word_position.Size = new System.Drawing.Size(75, 23);
            this.word_position.TabIndex = 0;
            this.word_position.Text = "0";
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(12, 628);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 35);
            this.bt_exit.TabIndex = 4;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transport_type);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.destination_node);
            this.groupBox1.Controls.Add(label12);
            this.groupBox1.Controls.Add(this.source_node);
            this.groupBox1.Controls.Add(label11);
            this.groupBox1.Controls.Add(this.bt_connection_data_read);
            this.groupBox1.Controls.Add(this.bt_close);
            this.groupBox1.Controls.Add(this.bt_connect);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.ip);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // transport_type
            // 
            this.transport_type.FormattingEnabled = true;
            this.transport_type.Location = new System.Drawing.Point(182, 142);
            this.transport_type.Name = "transport_type";
            this.transport_type.Size = new System.Drawing.Size(125, 23);
            this.transport_type.TabIndex = 17;
            this.transport_type.SelectionChangeCommitted += new System.EventHandler(this.transport_type_SelectionChangeCommitted);
            // 
            // destination_node
            // 
            this.destination_node.Enabled = false;
            this.destination_node.Location = new System.Drawing.Point(182, 113);
            this.destination_node.Name = "destination_node";
            this.destination_node.Size = new System.Drawing.Size(125, 23);
            this.destination_node.TabIndex = 12;
            // 
            // source_node
            // 
            this.source_node.Enabled = false;
            this.source_node.Location = new System.Drawing.Point(182, 84);
            this.source_node.Name = "source_node";
            this.source_node.Size = new System.Drawing.Size(125, 23);
            this.source_node.TabIndex = 10;
            // 
            // bt_connection_data_read
            // 
            this.bt_connection_data_read.Enabled = false;
            this.bt_connection_data_read.Location = new System.Drawing.Point(10, 216);
            this.bt_connection_data_read.Name = "bt_connection_data_read";
            this.bt_connection_data_read.Size = new System.Drawing.Size(165, 23);
            this.bt_connection_data_read.TabIndex = 4;
            this.bt_connection_data_read.Text = "Connection data read";
            this.bt_connection_data_read.UseVisualStyleBackColor = true;
            this.bt_connection_data_read.Click += new System.EventHandler(this.bt_connection_data_read_Click);
            // 
            // bt_close
            // 
            this.bt_close.Enabled = false;
            this.bt_close.Location = new System.Drawing.Point(100, 187);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(10, 187);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(84, 23);
            this.bt_connect.TabIndex = 2;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(182, 55);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(125, 23);
            this.port.TabIndex = 1;
            this.port.Text = "9600";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(182, 26);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(125, 23);
            this.ip.TabIndex = 0;
            this.ip.Text = "0.0.0.0";
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.groupDialogText);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.Location = new System.Drawing.Point(357, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Padding = new System.Windows.Forms.Padding(5);
            this.right_panel.Size = new System.Drawing.Size(523, 675);
            this.right_panel.TabIndex = 16;
            // 
            // groupDialogText
            // 
            this.groupDialogText.Controls.Add(this.dialog);
            this.groupDialogText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDialogText.Location = new System.Drawing.Point(5, 5);
            this.groupDialogText.Name = "groupDialogText";
            this.groupDialogText.Padding = new System.Windows.Forms.Padding(10);
            this.groupDialogText.Size = new System.Drawing.Size(513, 665);
            this.groupDialogText.TabIndex = 15;
            this.groupDialogText.TabStop = false;
            this.groupDialogText.Text = "Dialog";
            // 
            // dialog
            // 
            this.dialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialog.Location = new System.Drawing.Point(10, 26);
            this.dialog.Multiline = true;
            this.dialog.Name = "dialog";
            this.dialog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dialog.Size = new System.Drawing.Size(493, 629);
            this.dialog.TabIndex = 0;
            // 
            // TestPLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 675);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.left_panel);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TestPLC";
            this.Text = "Test mc.OMRON class";
            this.left_panel.ResumeLayout(false);
            this.groupBit.ResumeLayout(false);
            this.groupBit.PerformLayout();
            this.groupWord.ResumeLayout(false);
            this.groupWord.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.groupDialogText.ResumeLayout(false);
            this.groupDialogText.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel left_panel;
		private System.Windows.Forms.GroupBox groupBit;
		private System.Windows.Forms.Button bt_clear_bit;
		private System.Windows.Forms.Button bt_read_bit;
		private System.Windows.Forms.TextBox bit_position;
		private System.Windows.Forms.GroupBox groupWord;
		private System.Windows.Forms.Button bt_write_word;
		private System.Windows.Forms.Button bt_read_word;
		private System.Windows.Forms.TextBox word_position;
		private System.Windows.Forms.Button bt_exit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.Button bt_connect;
		private System.Windows.Forms.TextBox port;
		private System.Windows.Forms.TextBox ip;
		private System.Windows.Forms.Panel right_panel;
		private System.Windows.Forms.GroupBox groupDialogText;
		private System.Windows.Forms.TextBox dialog;
		private System.Windows.Forms.Button bt_connection_data_read;
		private System.Windows.Forms.TextBox word_value;
        private System.Windows.Forms.ComboBox word_memory_area;
        private System.Windows.Forms.TextBox destination_node;
        private System.Windows.Forms.TextBox source_node;
        private System.Windows.Forms.TextBox word_count;
        private System.Windows.Forms.TextBox bit_bit_position;
        private System.Windows.Forms.ComboBox bit_memory_area;
        private System.Windows.Forms.Button bt_raise_bit;
        private System.Windows.Forms.ComboBox transport_type;
        private System.Windows.Forms.CheckBox bit_value;
        private System.Windows.Forms.Button bt_speed_test;
        private System.Windows.Forms.TextBox word_repetition;
    }
}