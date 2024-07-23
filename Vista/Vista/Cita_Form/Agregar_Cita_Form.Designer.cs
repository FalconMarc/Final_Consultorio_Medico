namespace ConsultorioPrivado.Vista.Cita_Form
{
    partial class Agregar_Cita_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Cita_Form));
            cancelar_button = new Button();
            resetear_button = new Button();
            agregar_button = new Button();
            medicos = new Label();
            combo_Medicos = new ComboBox();
            GBx_Cita = new GroupBox();
            label1 = new Label();
            combo_Pacientes = new ComboBox();
            description = new Label();
            description_text = new TextBox();
            PBx_Close = new PictureBox();
            turnos_dgv = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            GBx_Cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBx_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnos_dgv).BeginInit();
            SuspendLayout();
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(397, 38);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(93, 38);
            cancelar_button.TabIndex = 31;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            cancelar_button.Click += cancelar_button_Click;
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(397, 173);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(93, 38);
            resetear_button.TabIndex = 26;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            resetear_button.Click += resetear_button_Click;
            // 
            // agregar_button
            // 
            agregar_button.Location = new Point(397, 107);
            agregar_button.Name = "agregar_button";
            agregar_button.Size = new Size(93, 38);
            agregar_button.TabIndex = 25;
            agregar_button.Text = "Aceptar";
            agregar_button.UseVisualStyleBackColor = true;
            agregar_button.Click += agregar_button_Click;
            // 
            // medicos
            // 
            medicos.AutoSize = true;
            medicos.Location = new Point(42, 66);
            medicos.Name = "medicos";
            medicos.Size = new Size(52, 15);
            medicos.TabIndex = 31;
            medicos.Text = "Medicos";
            // 
            // combo_Medicos
            // 
            combo_Medicos.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Medicos.FormattingEnabled = true;
            combo_Medicos.Location = new Point(123, 66);
            combo_Medicos.Name = "combo_Medicos";
            combo_Medicos.Size = new Size(220, 23);
            combo_Medicos.TabIndex = 32;
            combo_Medicos.SelectedIndexChanged += combo_Medicos_SelectedIndexChanged;
            // 
            // GBx_Cita
            // 
            GBx_Cita.BackColor = SystemColors.ButtonHighlight;
            GBx_Cita.Controls.Add(label1);
            GBx_Cita.Controls.Add(combo_Pacientes);
            GBx_Cita.Controls.Add(description);
            GBx_Cita.Controls.Add(combo_Medicos);
            GBx_Cita.Controls.Add(description_text);
            GBx_Cita.Controls.Add(medicos);
            GBx_Cita.Location = new Point(10, 26);
            GBx_Cita.Margin = new Padding(3, 2, 3, 2);
            GBx_Cita.Name = "GBx_Cita";
            GBx_Cita.Padding = new Padding(3, 2, 3, 2);
            GBx_Cita.Size = new Size(365, 187);
            GBx_Cita.TabIndex = 33;
            GBx_Cita.TabStop = false;
            GBx_Cita.Text = "Detalles de la cita";
            GBx_Cita.Enter += GBx_Cita_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 37;
            label1.Text = "Paciente";
            // 
            // combo_Pacientes
            // 
            combo_Pacientes.BackColor = SystemColors.ButtonHighlight;
            combo_Pacientes.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Pacientes.ForeColor = SystemColors.Desktop;
            combo_Pacientes.FormattingEnabled = true;
            combo_Pacientes.Location = new Point(123, 24);
            combo_Pacientes.Name = "combo_Pacientes";
            combo_Pacientes.Size = new Size(220, 23);
            combo_Pacientes.TabIndex = 30;
            // 
            // description
            // 
            description.AutoSize = true;
            description.BackColor = SystemColors.ButtonHighlight;
            description.Location = new Point(42, 124);
            description.Name = "description";
            description.Size = new Size(69, 15);
            description.TabIndex = 17;
            description.Text = "Descripcion";
            // 
            // description_text
            // 
            description_text.Location = new Point(123, 121);
            description_text.Multiline = true;
            description_text.Name = "description_text";
            description_text.Size = new Size(220, 49);
            description_text.TabIndex = 21;
            // 
            // PBx_Close
            // 
            PBx_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PBx_Close.Image = (Image)resources.GetObject("PBx_Close.Image");
            PBx_Close.Location = new Point(507, 0);
            PBx_Close.Margin = new Padding(3, 2, 3, 2);
            PBx_Close.Name = "PBx_Close";
            PBx_Close.Size = new Size(24, 21);
            PBx_Close.SizeMode = PictureBoxSizeMode.Zoom;
            PBx_Close.TabIndex = 32;
            PBx_Close.TabStop = false;
            PBx_Close.Click += PBx_Close_Click;
            // 
            // turnos_dgv
            // 
            turnos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            turnos_dgv.Location = new Point(12, 254);
            turnos_dgv.Name = "turnos_dgv";
            turnos_dgv.Size = new Size(478, 228);
            turnos_dgv.TabIndex = 37;
            turnos_dgv.CellClick += turnos_dgv_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 38;
            label2.Text = "Turnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 225);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 39;
            label3.Text = "0:00";
            // 
            // Agregar_Cita_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(532, 507);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(turnos_dgv);
            Controls.Add(PBx_Close);
            Controls.Add(cancelar_button);
            Controls.Add(resetear_button);
            Controls.Add(agregar_button);
            Controls.Add(GBx_Cita);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Agregar_Cita_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Cita";
            Load += Agregar_Cita_Form_Load;
            GBx_Cita.ResumeLayout(false);
            GBx_Cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBx_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnos_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelar_button;
        private Button resetear_button;
        private Button agregar_button;
        private Label medicos;
        private ComboBox combo_Medicos;
        private GroupBox GBx_Cita;
        private Label description;
        private TextBox description_text;
        private ComboBox combo_Pacientes;
        private PictureBox PBx_Close;
        private Label label1;
        private DataGridView turnos_dgv;
        private Label label2;
        private Label label3;
    }
}