﻿namespace ConsultorioPrivado
{
    partial class Principal_form
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_form));
            flowLayoutPanel1 = new FlowLayoutPanel();
            agendaCitas_button = new Button();
            agendarCitas_button = new Button();
            pacientes_button = new Button();
            medicos_Button = new Button();
            principal_panel = new Panel();
            btn_turnos = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(agendaCitas_button);
            flowLayoutPanel1.Controls.Add(agendarCitas_button);
            flowLayoutPanel1.Controls.Add(pacientes_button);
            flowLayoutPanel1.Controls.Add(medicos_Button);
            flowLayoutPanel1.Controls.Add(btn_turnos);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(2, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(109, 349);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // agendaCitas_button
            // 
            agendaCitas_button.Location = new Point(3, 3);
            agendaCitas_button.Name = "agendaCitas_button";
            agendaCitas_button.Size = new Size(100, 55);
            agendaCitas_button.TabIndex = 4;
            agendaCitas_button.Text = "Agenda";
            agendaCitas_button.UseVisualStyleBackColor = true;
            agendaCitas_button.Click += agendacitas_button_Click;
            // 
            // agendarCitas_button
            // 
            agendarCitas_button.Location = new Point(3, 64);
            agendarCitas_button.Name = "agendarCitas_button";
            agendarCitas_button.Size = new Size(100, 56);
            agendarCitas_button.TabIndex = 1;
            agendarCitas_button.Text = "Agendar Cita";
            agendarCitas_button.UseVisualStyleBackColor = true;
            agendarCitas_button.Click += button1_Click;
            // 
            // pacientes_button
            // 
            pacientes_button.Location = new Point(3, 126);
            pacientes_button.Name = "pacientes_button";
            pacientes_button.Size = new Size(100, 55);
            pacientes_button.TabIndex = 2;
            pacientes_button.Text = "Pacientes";
            pacientes_button.UseVisualStyleBackColor = true;
            pacientes_button.Click += pacientes_button_Click;
            // 
            // medicos_Button
            // 
            medicos_Button.Location = new Point(3, 187);
            medicos_Button.Name = "medicos_Button";
            medicos_Button.Size = new Size(100, 54);
            medicos_Button.TabIndex = 3;
            medicos_Button.Text = "Medicos";
            medicos_Button.UseVisualStyleBackColor = true;
            medicos_Button.Click += medicos_Button_Click;
            // 
            // principal_panel
            // 
            principal_panel.Location = new Point(114, 29);
            principal_panel.Name = "principal_panel";
            principal_panel.Size = new Size(874, 420);
            principal_panel.TabIndex = 1;
            // 
            // btn_turnos
            // 
            btn_turnos.Location = new Point(3, 247);
            btn_turnos.Name = "btn_turnos";
            btn_turnos.Size = new Size(100, 57);
            btn_turnos.TabIndex = 5;
            btn_turnos.Text = "Turnos";
            btn_turnos.UseVisualStyleBackColor = true;
            // 
            // Principal_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(principal_panel);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultorio";
            Load += Principal_form_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button agendarCitas_button;
        private Panel principal_panel;
        private Button pacientes_button;
        private Button medicos_Button;
        private Button agendaCitas_button;
        private Button btn_turnos;
    }
}
