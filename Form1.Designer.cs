using System.Diagnostics;

namespace Travel_Plan
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private CheckBox GetCheckBox21()
        {
            return checkBox2;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            rBtnTren = new RadioButton();
            rBtnAutomovil = new RadioButton();
            rBtnAvion = new RadioButton();
            rBtnBus = new RadioButton();
            groupBox4 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            listBox1 = new ListBox();
            label8 = new Label();
            btnCotizar = new Button();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 27, 34);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 108);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(342, 20);
            label2.TabIndex = 1;
            label2.Text = "Cotizador de viajes · Configura tu próximo destino";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 0;
            label1.Text = "TravelPlan";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(22, 27, 34);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Viajero";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 30, 30);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.ForeColor = Color.FromArgb(224, 224, 224);
            textBox2.Location = new Point(123, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 82);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 2;
            label4.Text = "Días de Viaje:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.ForeColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(167, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 38);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre del Viajero:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(22, 27, 34);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(12, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(779, 307);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selección del Destino";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(30, 30, 30);
            comboBox3.ForeColor = Color.White;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(18, 248);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(309, 28);
            comboBox3.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 212);
            label7.Name = "label7";
            label7.Size = new Size(67, 23);
            label7.TabIndex = 4;
            label7.Text = "Ciudad";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(30, 30, 30);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(18, 161);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(309, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 124);
            label5.Name = "label5";
            label5.Size = new Size(201, 23);
            label5.TabIndex = 2;
            label5.Text = "Departamento / Región";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(30, 30, 30);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Perú", "Colombia", "Chile", "Argentina", "Mexico" });
            comboBox1.Location = new Point(18, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 37);
            label6.Name = "label6";
            label6.Size = new Size(41, 23);
            label6.TabIndex = 0;
            label6.Text = "País";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(22, 27, 34);
            groupBox3.Controls.Add(rBtnTren);
            groupBox3.Controls.Add(rBtnAutomovil);
            groupBox3.Controls.Add(rBtnAvion);
            groupBox3.Controls.Add(rBtnBus);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(384, 634);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(407, 122);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Medio de Transporte";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // rBtnTren
            // 
            rBtnTren.AutoSize = true;
            rBtnTren.Location = new Point(99, 59);
            rBtnTren.Name = "rBtnTren";
            rBtnTren.Size = new Size(58, 24);
            rBtnTren.TabIndex = 7;
            rBtnTren.TabStop = true;
            rBtnTren.Text = "Tren";
            rBtnTren.UseVisualStyleBackColor = true;
            // 
            // rBtnAutomovil
            // 
            rBtnAutomovil.AutoSize = true;
            rBtnAutomovil.Location = new Point(292, 59);
            rBtnAutomovil.Name = "rBtnAutomovil";
            rBtnAutomovil.Size = new Size(99, 24);
            rBtnAutomovil.TabIndex = 6;
            rBtnAutomovil.TabStop = true;
            rBtnAutomovil.Text = "Automóvil";
            rBtnAutomovil.UseVisualStyleBackColor = true;
            // 
            // rBtnAvion
            // 
            rBtnAvion.AutoSize = true;
            rBtnAvion.Location = new Point(193, 59);
            rBtnAvion.Name = "rBtnAvion";
            rBtnAvion.Size = new Size(68, 24);
            rBtnAvion.TabIndex = 1;
            rBtnAvion.TabStop = true;
            rBtnAvion.Text = "Avión";
            rBtnAvion.UseVisualStyleBackColor = true;
            // 
            // rBtnBus
            // 
            rBtnBus.AutoSize = true;
            rBtnBus.Location = new Point(17, 59);
            rBtnBus.Name = "rBtnBus";
            rBtnBus.Size = new Size(53, 24);
            rBtnBus.TabIndex = 0;
            rBtnBus.TabStop = true;
            rBtnBus.Text = "Bus";
            rBtnBus.UseVisualStyleBackColor = true;
            rBtnBus.CheckedChanged += rBtnBus_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(22, 27, 34);
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(23, 634);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(338, 122);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Servicios Adicionales";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(184, 83);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(136, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Seguro de Viaje";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(18, 83);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(112, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Tour Guiado";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(184, 43);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Desayuno";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Hotel";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(22, 27, 34);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(23, 816);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(768, 144);
            listBox1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 781);
            label8.Name = "label8";
            label8.Size = new Size(218, 23);
            label8.TabIndex = 6;
            label8.Text = "Resultado de la cotización";
            // 
            // btnCotizar
            // 
            btnCotizar.BackColor = Color.FromArgb(30, 101, 83);
            btnCotizar.FlatStyle = FlatStyle.Popup;
            btnCotizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCotizar.ForeColor = Color.White;
            btnCotizar.Location = new Point(100, 977);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(239, 57);
            btnCotizar.TabIndex = 9;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = false;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(58, 71, 80);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(483, 977);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(239, 57);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(13, 17, 23);
            ClientSize = new Size(803, 1055);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCotizar);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox3;
        private Label label7;
        private GroupBox groupBox3;
        private RadioButton rBtnAutomovil;
        private RadioButton rBtnAvion;
        private RadioButton rBtnBus;
        private GroupBox groupBox4;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private RadioButton rBtnTren;
        private ListBox listBox1;
        private Label label8;
        private Button btnCotizar;
        private Button button1;
        private Button btnLimpiar;
        private EventHandler checkBox2_CheckedChanged;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
