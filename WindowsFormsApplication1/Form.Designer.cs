namespace Graph
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddVertex = new System.Windows.Forms.Button();
            this.buttonAddEdge = new System.Windows.Forms.Button();
            this.textBoxVertex = new System.Windows.Forms.TextBox();
            this.textBoxEdge = new System.Windows.Forms.TextBox();
            this.buttonDfs = new System.Windows.Forms.Button();
            this.textBoxDfs = new System.Windows.Forms.TextBox();
            this.buttonBfs = new System.Windows.Forms.Button();
            this.textBoxBfs = new System.Windows.Forms.TextBox();
            this.buttonKraskala = new System.Windows.Forms.Button();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(335, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 702);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // buttonAddVertex
            // 
            this.buttonAddVertex.Location = new System.Drawing.Point(12, 29);
            this.buttonAddVertex.Name = "buttonAddVertex";
            this.buttonAddVertex.Size = new System.Drawing.Size(136, 60);
            this.buttonAddVertex.TabIndex = 1;
            this.buttonAddVertex.Text = "Add Vertex";
            this.buttonAddVertex.UseVisualStyleBackColor = true;
            this.buttonAddVertex.Click += new System.EventHandler(this.buttonAddVertex_Click);
            // 
            // buttonAddEdge
            // 
            this.buttonAddEdge.Location = new System.Drawing.Point(12, 112);
            this.buttonAddEdge.Name = "buttonAddEdge";
            this.buttonAddEdge.Size = new System.Drawing.Size(136, 60);
            this.buttonAddEdge.TabIndex = 2;
            this.buttonAddEdge.Text = "Add Edge";
            this.buttonAddEdge.UseVisualStyleBackColor = true;
            this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
            // 
            // textBoxVertex
            // 
            this.textBoxVertex.Enabled = false;
            this.textBoxVertex.Location = new System.Drawing.Point(154, 46);
            this.textBoxVertex.Name = "textBoxVertex";
            this.textBoxVertex.Size = new System.Drawing.Size(139, 26);
            this.textBoxVertex.TabIndex = 3;
            // 
            // textBoxEdge
            // 
            this.textBoxEdge.Enabled = false;
            this.textBoxEdge.Location = new System.Drawing.Point(154, 129);
            this.textBoxEdge.Name = "textBoxEdge";
            this.textBoxEdge.Size = new System.Drawing.Size(139, 26);
            this.textBoxEdge.TabIndex = 4;
            // 
            // buttonDfs
            // 
            this.buttonDfs.Location = new System.Drawing.Point(12, 195);
            this.buttonDfs.Name = "buttonDfs";
            this.buttonDfs.Size = new System.Drawing.Size(176, 46);
            this.buttonDfs.TabIndex = 5;
            this.buttonDfs.Text = "Depth-first search";
            this.buttonDfs.UseVisualStyleBackColor = true;
            this.buttonDfs.Click += new System.EventHandler(this.buttonDfs_Click);
            // 
            // textBoxDfs
            // 
            this.textBoxDfs.Location = new System.Drawing.Point(12, 263);
            this.textBoxDfs.Multiline = true;
            this.textBoxDfs.Name = "textBoxDfs";
            this.textBoxDfs.Size = new System.Drawing.Size(272, 91);
            this.textBoxDfs.TabIndex = 6;
            // 
            // buttonBfs
            // 
            this.buttonBfs.Location = new System.Drawing.Point(12, 377);
            this.buttonBfs.Name = "buttonBfs";
            this.buttonBfs.Size = new System.Drawing.Size(176, 46);
            this.buttonBfs.TabIndex = 7;
            this.buttonBfs.Text = "Breadth-first search";
            this.buttonBfs.UseVisualStyleBackColor = true;
            this.buttonBfs.Click += new System.EventHandler(this.buttonBfs_Click);
            // 
            // textBoxBfs
            // 
            this.textBoxBfs.Location = new System.Drawing.Point(12, 446);
            this.textBoxBfs.Multiline = true;
            this.textBoxBfs.Name = "textBoxBfs";
            this.textBoxBfs.Size = new System.Drawing.Size(272, 91);
            this.textBoxBfs.TabIndex = 8;
            // 
            // buttonKraskala
            // 
            this.buttonKraskala.Location = new System.Drawing.Point(12, 563);
            this.buttonKraskala.Name = "buttonKraskala";
            this.buttonKraskala.Size = new System.Drawing.Size(176, 43);
            this.buttonKraskala.TabIndex = 10;
            this.buttonKraskala.Text = "Kraskala\'s algorithm";
            this.buttonKraskala.UseVisualStyleBackColor = true;
            this.buttonKraskala.Click += new System.EventHandler(this.buttonKraskala_Click);
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.Location = new System.Drawing.Point(20, 640);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Size = new System.Drawing.Size(167, 42);
            this.buttonDijkstra.TabIndex = 11;
            this.buttonDijkstra.Text = "Dijkstra\'s algoritm";
            this.buttonDijkstra.UseVisualStyleBackColor = true;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 757);
            this.Controls.Add(this.buttonDijkstra);
            this.Controls.Add(this.buttonKraskala);
            this.Controls.Add(this.textBoxBfs);
            this.Controls.Add(this.buttonBfs);
            this.Controls.Add(this.textBoxDfs);
            this.Controls.Add(this.buttonDfs);
            this.Controls.Add(this.textBoxEdge);
            this.Controls.Add(this.textBoxVertex);
            this.Controls.Add(this.buttonAddEdge);
            this.Controls.Add(this.buttonAddVertex);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddVertex;
        private System.Windows.Forms.Button buttonAddEdge;
        private System.Windows.Forms.TextBox textBoxVertex;
        private System.Windows.Forms.TextBox textBoxEdge;
        private System.Windows.Forms.Button buttonDfs;
        private System.Windows.Forms.TextBox textBoxDfs;
        private System.Windows.Forms.Button buttonBfs;
        private System.Windows.Forms.TextBox textBoxBfs;
        private System.Windows.Forms.Button buttonKraskala;
        private System.Windows.Forms.Button buttonDijkstra;
    }
}

