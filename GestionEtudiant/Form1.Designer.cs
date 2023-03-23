namespace GestionEtudiant
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.btnafich = new System.Windows.Forms.Button();
            this.btnajt = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textage = new System.Windows.Forms.TextBox();
            this.btnmsg = new System.Windows.Forms.Button();
            this.btnsup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(91, 47);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(530, 198);
            this.grd.TabIndex = 0;
            // 
            // btnafich
            // 
            this.btnafich.Location = new System.Drawing.Point(524, 18);
            this.btnafich.Name = "btnafich";
            this.btnafich.Size = new System.Drawing.Size(92, 23);
            this.btnafich.TabIndex = 1;
            this.btnafich.Text = "Afficher";
            this.btnafich.UseVisualStyleBackColor = true;
            this.btnafich.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnajt
            // 
            this.btnajt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnajt.Location = new System.Drawing.Point(345, 330);
            this.btnajt.Name = "btnajt";
            this.btnajt.Size = new System.Drawing.Size(82, 23);
            this.btnajt.TabIndex = 2;
            this.btnajt.Text = "Ajouter";
            this.btnajt.UseVisualStyleBackColor = false;
            this.btnajt.Click += new System.EventHandler(this.btnajt_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(91, 261);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(91, 292);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(26, 13);
            this.age.TabIndex = 4;
            this.age.Text = "Age";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(196, 261);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(192, 20);
            this.textname.TabIndex = 7;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(196, 292);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(192, 20);
            this.textage.TabIndex = 8;
            this.textage.TextChanged += new System.EventHandler(this.textage_TextChanged);
            // 
            // btnmsg
            // 
            this.btnmsg.Location = new System.Drawing.Point(257, 330);
            this.btnmsg.Name = "btnmsg";
            this.btnmsg.Size = new System.Drawing.Size(82, 23);
            this.btnmsg.TabIndex = 10;
            this.btnmsg.Text = "Mise a Ajour";
            this.btnmsg.UseVisualStyleBackColor = true;
            this.btnmsg.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnsup
            // 
            this.btnsup.BackColor = System.Drawing.Color.Red;
            this.btnsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsup.Location = new System.Drawing.Point(524, 251);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(82, 23);
            this.btnsup.TabIndex = 11;
            this.btnsup.Text = "Supprimer";
            this.btnsup.UseVisualStyleBackColor = false;
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsup);
            this.Controls.Add(this.btnmsg);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnajt);
            this.Controls.Add(this.btnafich);
            this.Controls.Add(this.grd);
            this.Name = "Form1";
            this.Text = "Gestion Des Etudiants";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button btnafich;
        private System.Windows.Forms.Button btnajt;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.Button btnmsg;
        private System.Windows.Forms.Button btnsup;
        private System.Windows.Forms.Button button1;
    }
}

