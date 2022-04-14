
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btn綠茶 = new System.Windows.Forms.Button();
            this.btn奶茶 = new System.Windows.Forms.Button();
            this.btnCoke = new System.Windows.Forms.Button();
            this.btn紅茶 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(273, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "冰涼冷飲自動販賣機";
            // 
            // lblResponse
            // 
            this.lblResponse.BackColor = System.Drawing.Color.Moccasin;
            this.lblResponse.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResponse.Location = new System.Drawing.Point(33, 55);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(736, 216);
            this.lblResponse.TabIndex = 1;
            this.lblResponse.Text = "回應訊息";
            // 
            // btn綠茶
            // 
            this.btn綠茶.BackColor = System.Drawing.Color.GreenYellow;
            this.btn綠茶.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn綠茶.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn綠茶.Location = new System.Drawing.Point(227, 306);
            this.btn綠茶.Name = "btn綠茶";
            this.btn綠茶.Size = new System.Drawing.Size(152, 115);
            this.btn綠茶.TabIndex = 3;
            this.btn綠茶.Text = "綠茶";
            this.btn綠茶.UseVisualStyleBackColor = false;
            this.btn綠茶.Click += new System.EventHandler(this.btn綠茶_Click);
            // 
            // btn奶茶
            // 
            this.btn奶茶.BackColor = System.Drawing.Color.Plum;
            this.btn奶茶.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn奶茶.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn奶茶.Location = new System.Drawing.Point(423, 306);
            this.btn奶茶.Name = "btn奶茶";
            this.btn奶茶.Size = new System.Drawing.Size(155, 115);
            this.btn奶茶.TabIndex = 4;
            this.btn奶茶.Text = "奶茶";
            this.btn奶茶.UseVisualStyleBackColor = false;
            this.btn奶茶.Click += new System.EventHandler(this.btn奶茶_Click);
            // 
            // btnCoke
            // 
            this.btnCoke.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCoke.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnCoke.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCoke.Location = new System.Drawing.Point(618, 306);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(151, 115);
            this.btnCoke.TabIndex = 5;
            this.btnCoke.Text = "可樂";
            this.btnCoke.UseVisualStyleBackColor = false;
            this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
            // 
            // btn紅茶
            // 
            this.btn紅茶.BackColor = System.Drawing.Color.LightCoral;
            this.btn紅茶.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn紅茶.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn紅茶.Location = new System.Drawing.Point(34, 306);
            this.btn紅茶.Name = "btn紅茶";
            this.btn紅茶.Size = new System.Drawing.Size(148, 115);
            this.btn紅茶.TabIndex = 2;
            this.btn紅茶.Text = "紅茶";
            this.btn紅茶.UseVisualStyleBackColor = false;
            this.btn紅茶.Click += new System.EventHandler(this.btn紅茶_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(799, 549);
            this.Controls.Add(this.btnCoke);
            this.Controls.Add(this.btn奶茶);
            this.Controls.Add(this.btn綠茶);
            this.Controls.Add(this.btn紅茶);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "冷飲自動販賣機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btn綠茶;
        private System.Windows.Forms.Button btn奶茶;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btn紅茶;
    }
}

