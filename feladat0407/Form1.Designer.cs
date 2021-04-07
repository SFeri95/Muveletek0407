namespace feladat0407
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbMuvelet = new System.Windows.Forms.Label();
            this.lbEredmeny = new System.Windows.Forms.Label();
            this.btEllenoriz = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.összeadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivonásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szorzásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osztásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btKovetkezo = new System.Windows.Forms.Button();
            this.lbfeladat = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbEredmeny = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libTeljesitmeny = new System.Windows.Forms.ListBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMuvelet
            // 
            this.lbMuvelet.AutoSize = true;
            this.lbMuvelet.Location = new System.Drawing.Point(121, 74);
            this.lbMuvelet.Name = "lbMuvelet";
            this.lbMuvelet.Size = new System.Drawing.Size(45, 13);
            this.lbMuvelet.TabIndex = 0;
            this.lbMuvelet.Text = "Művelet";
            this.lbMuvelet.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbEredmeny
            // 
            this.lbEredmeny.AutoSize = true;
            this.lbEredmeny.Location = new System.Drawing.Point(462, 74);
            this.lbEredmeny.Name = "lbEredmeny";
            this.lbEredmeny.Size = new System.Drawing.Size(54, 13);
            this.lbEredmeny.TabIndex = 1;
            this.lbEredmeny.Text = "Eredmeny";
            // 
            // btEllenoriz
            // 
            this.btEllenoriz.Location = new System.Drawing.Point(357, 71);
            this.btEllenoriz.Name = "btEllenoriz";
            this.btEllenoriz.Size = new System.Drawing.Size(75, 23);
            this.btEllenoriz.TabIndex = 2;
            this.btEllenoriz.Text = "Ellenőriz";
            this.btEllenoriz.UseVisualStyleBackColor = true;
            this.btEllenoriz.Click += new System.EventHandler(this.btEllenoriz_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kilépésToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(598, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.összeadásToolStripMenuItem,
            this.kivonásToolStripMenuItem,
            this.szorzásToolStripMenuItem,
            this.osztásToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Műveletek";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // összeadásToolStripMenuItem
            // 
            this.összeadásToolStripMenuItem.Name = "összeadásToolStripMenuItem";
            this.összeadásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.összeadásToolStripMenuItem.Text = "Összeadás";
            // 
            // kivonásToolStripMenuItem
            // 
            this.kivonásToolStripMenuItem.Name = "kivonásToolStripMenuItem";
            this.kivonásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kivonásToolStripMenuItem.Text = "Kivonás";
            // 
            // szorzásToolStripMenuItem
            // 
            this.szorzásToolStripMenuItem.Name = "szorzásToolStripMenuItem";
            this.szorzásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szorzásToolStripMenuItem.Text = "Szorzás";
            // 
            // osztásToolStripMenuItem
            // 
            this.osztásToolStripMenuItem.Name = "osztásToolStripMenuItem";
            this.osztásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osztásToolStripMenuItem.Text = "Osztás";
            this.osztásToolStripMenuItem.Click += new System.EventHandler(this.osztásToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // btKovetkezo
            // 
            this.btKovetkezo.Location = new System.Drawing.Point(357, 117);
            this.btKovetkezo.Name = "btKovetkezo";
            this.btKovetkezo.Size = new System.Drawing.Size(75, 23);
            this.btKovetkezo.TabIndex = 9;
            this.btKovetkezo.Text = "Következő";
            this.btKovetkezo.UseVisualStyleBackColor = true;
            // 
            // lbfeladat
            // 
            this.lbfeladat.AutoSize = true;
            this.lbfeladat.Location = new System.Drawing.Point(13, 72);
            this.lbfeladat.Name = "lbfeladat";
            this.lbfeladat.Size = new System.Drawing.Size(45, 13);
            this.lbfeladat.TabIndex = 16;
            this.lbfeladat.Text = "Feladat:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tbEredmeny
            // 
            this.tbEredmeny.Location = new System.Drawing.Point(222, 74);
            this.tbEredmeny.Name = "tbEredmeny";
            this.tbEredmeny.Size = new System.Drawing.Size(100, 20);
            this.tbEredmeny.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libTeljesitmeny
            // 
            this.libTeljesitmeny.FormattingEnabled = true;
            this.libTeljesitmeny.Location = new System.Drawing.Point(49, 117);
            this.libTeljesitmeny.Name = "libTeljesitmeny";
            this.libTeljesitmeny.Size = new System.Drawing.Size(273, 134);
            this.libTeljesitmeny.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 312);
            this.Controls.Add(this.tbEredmeny);
            this.Controls.Add(this.lbfeladat);
            this.Controls.Add(this.libTeljesitmeny);
            this.Controls.Add(this.btKovetkezo);
            this.Controls.Add(this.btEllenoriz);
            this.Controls.Add(this.lbEredmeny);
            this.Controls.Add(this.lbMuvelet);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMuvelet;
        private System.Windows.Forms.Label lbEredmeny;
        private System.Windows.Forms.Button btEllenoriz;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem összeadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivonásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szorzásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osztásToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Button btKovetkezo;
        private System.Windows.Forms.Label lbfeladat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox tbEredmeny;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox libTeljesitmeny;
    }
}

