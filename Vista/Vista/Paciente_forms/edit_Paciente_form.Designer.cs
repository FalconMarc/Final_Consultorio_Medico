﻿namespace ConsultorioPrivado.Vista.Paciente_forms
{
    partial class edit_Paciente_form
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
            id_textBox = new TextBox();
            label5 = new Label();
            cancelar_button = new Button();
            telefono_textBox = new TextBox();
            telefono_label = new Label();
            resetear_button = new Button();
            agregar_button = new Button();
            correo_textBox = new TextBox();
            cedula_textBox = new TextBox();
            apellido_textBox = new TextBox();
            nombre_textBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // id_textBox
            // 
            id_textBox.Enabled = false;
            id_textBox.Location = new Point(162, 28);
            id_textBox.Margin = new Padding(3, 4, 3, 4);
            id_textBox.Name = "id_textBox";
            id_textBox.Size = new Size(114, 27);
            id_textBox.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 28);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 32;
            label5.Text = "Id";
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(127, 397);
            cancelar_button.Margin = new Padding(3, 4, 3, 4);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(86, 31);
            cancelar_button.TabIndex = 31;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            // 
            // telefono_textBox
            // 
            telefono_textBox.Location = new Point(167, 278);
            telefono_textBox.Margin = new Padding(3, 4, 3, 4);
            telefono_textBox.Name = "telefono_textBox";
            telefono_textBox.Size = new Size(114, 27);
            telefono_textBox.TabIndex = 28;
            // 
            // telefono_label
            // 
            telefono_label.AutoSize = true;
            telefono_label.Location = new Point(47, 278);
            telefono_label.Name = "telefono_label";
            telefono_label.Size = new Size(67, 20);
            telefono_label.TabIndex = 27;
            telefono_label.Text = "Telefono";
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(191, 347);
            resetear_button.Margin = new Padding(3, 4, 3, 4);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(86, 31);
            resetear_button.TabIndex = 26;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            // 
            // agregar_button
            // 
            agregar_button.Location = new Point(70, 347);
            agregar_button.Margin = new Padding(3, 4, 3, 4);
            agregar_button.Name = "agregar_button";
            agregar_button.Size = new Size(86, 31);
            agregar_button.TabIndex = 25;
            agregar_button.Text = "Aceptar";
            agregar_button.UseVisualStyleBackColor = true;
            agregar_button.Click += agregar_button_Click;
            // 
            // correo_textBox
            // 
            correo_textBox.Location = new Point(167, 222);
            correo_textBox.Margin = new Padding(3, 4, 3, 4);
            correo_textBox.Name = "correo_textBox";
            correo_textBox.Size = new Size(114, 27);
            correo_textBox.TabIndex = 24;
            // 
            // cedula_textBox
            // 
            cedula_textBox.Location = new Point(167, 167);
            cedula_textBox.Margin = new Padding(3, 4, 3, 4);
            cedula_textBox.Name = "cedula_textBox";
            cedula_textBox.Size = new Size(114, 27);
            cedula_textBox.TabIndex = 23;
            // 
            // apellido_textBox
            // 
            apellido_textBox.Location = new Point(167, 120);
            apellido_textBox.Margin = new Padding(3, 4, 3, 4);
            apellido_textBox.Name = "apellido_textBox";
            apellido_textBox.Size = new Size(114, 27);
            apellido_textBox.TabIndex = 22;
            // 
            // nombre_textBox
            // 
            nombre_textBox.Location = new Point(167, 68);
            nombre_textBox.Margin = new Padding(3, 4, 3, 4);
            nombre_textBox.Name = "nombre_textBox";
            nombre_textBox.Size = new Size(114, 27);
            nombre_textBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 222);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 20;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 167);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 19;
            label3.Text = "Cedula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 120);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 68);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // edit_Paciente_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 507);
            Controls.Add(id_textBox);
            Controls.Add(label5);
            Controls.Add(cancelar_button);
            Controls.Add(telefono_textBox);
            Controls.Add(telefono_label);
            Controls.Add(resetear_button);
            Controls.Add(agregar_button);
            Controls.Add(correo_textBox);
            Controls.Add(cedula_textBox);
            Controls.Add(apellido_textBox);
            Controls.Add(nombre_textBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "edit_Paciente_form";
            Text = "Editar Paciente";
            Load += edit_Paciente_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id_textBox;
        private Label label5;
        private Button cancelar_button;
        private TextBox telefono_textBox;
        private Label telefono_label;
        private Button resetear_button;
        private Button agregar_button;
        private TextBox correo_textBox;
        private TextBox cedula_textBox;
        private TextBox apellido_textBox;
        private TextBox nombre_textBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}