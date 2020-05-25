namespace sc2_strat_roulette
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_1 = new System.Windows.Forms.Button();
            this.in_party = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.in_party, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.content, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.55346F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.44654F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_1.Location = new System.Drawing.Point(97, 3);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(176, 93);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Generate build";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // in_party
            // 
            this.in_party.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.in_party.AutoSize = true;
            this.in_party.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.in_party.Location = new System.Drawing.Point(100, 114);
            this.in_party.Name = "in_party";
            this.in_party.Size = new System.Drawing.Size(170, 29);
            this.in_party.TabIndex = 1;
            this.in_party.Text = "Playing in party";
            this.in_party.UseVisualStyleBackColor = true;
            this.in_party.CheckedChanged += new System.EventHandler(this.in_party_CheckedChanged);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(185, 161);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 29);
            this.title.TabIndex = 2;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.content.AutoSize = true;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.content.Location = new System.Drawing.Point(185, 215);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(0, 105);
            this.content.TabIndex = 3;
            this.content.Click += new System.EventHandler(this.content_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SC2 Co-op strat roulette";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.CheckBox in_party;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label content;
    }
}

