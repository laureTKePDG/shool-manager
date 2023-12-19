
namespace shool_manager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.telephone_label = new System.Windows.Forms.Label();
            this.first_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.retrieve_button = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BackgroundImage = global::shool_manager.Properties.Resources.istockphoto_596352914_612x612;
            this.panel1.Location = new System.Drawing.Point(613, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 515);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "STUDENTS MANAGER";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.year_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_label.Location = new System.Drawing.Point(118, 412);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(74, 26);
            this.year_label.TabIndex = 3;
            this.year_label.Text = "Year :";
            this.year_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.email_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(118, 348);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(87, 26);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "Email :";
            this.email_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // telephone_label
            // 
            this.telephone_label.AutoSize = true;
            this.telephone_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.telephone_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone_label.Location = new System.Drawing.Point(118, 291);
            this.telephone_label.Name = "telephone_label";
            this.telephone_label.Size = new System.Drawing.Size(130, 26);
            this.telephone_label.TabIndex = 5;
            this.telephone_label.Text = "Telephone :";
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.first_name_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_label.Location = new System.Drawing.Point(118, 216);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(141, 26);
            this.first_name_label.TabIndex = 6;
            this.first_name_label.Text = "First Name :";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.last_name_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_label.Location = new System.Drawing.Point(118, 129);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(136, 26);
            this.last_name_label.TabIndex = 7;
            this.last_name_label.Text = "Last Name :";
            this.last_name_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // last_name
            // 
            this.last_name.BackColor = System.Drawing.SystemColors.Window;
            this.last_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.Location = new System.Drawing.Point(338, 140);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(249, 29);
            this.last_name.TabIndex = 8;
            this.last_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // first_name
            // 
            this.first_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(338, 216);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(249, 29);
            this.first_name.TabIndex = 9;
            this.first_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // telephone
            // 
            this.telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone.Location = new System.Drawing.Point(338, 291);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(249, 29);
            this.telephone.TabIndex = 10;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(338, 355);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(249, 29);
            this.email.TabIndex = 11;
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.SystemColors.Window;
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(338, 412);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(249, 29);
            this.year.TabIndex = 12;
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insert_button.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.insert_button.Location = new System.Drawing.Point(338, 467);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(111, 33);
            this.insert_button.TabIndex = 0;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // retrieve_button
            // 
            this.retrieve_button.BackColor = System.Drawing.Color.DarkGreen;
            this.retrieve_button.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieve_button.Location = new System.Drawing.Point(487, 467);
            this.retrieve_button.Name = "retrieve_button";
            this.retrieve_button.Size = new System.Drawing.Size(120, 33);
            this.retrieve_button.TabIndex = 13;
            this.retrieve_button.Text = "Retrieve";
            this.retrieve_button.UseVisualStyleBackColor = false;
            this.retrieve_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkGreen;
            this.update.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(174, 467);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(120, 33);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Code
            // 
            this.Code.BackColor = System.Drawing.SystemColors.Window;
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(338, 78);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(249, 29);
            this.Code.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Code :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(929, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.update);
            this.Controls.Add(this.retrieve_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.year);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.telephone_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "Form1";
            this.Text = " Insert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label telephone_label;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button retrieve_button;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label2;
    }
}

