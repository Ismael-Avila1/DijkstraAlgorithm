namespace DijkstraAlgorithm
{
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelRemainingVertices = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreateVertices = new System.Windows.Forms.Button();
            this.numericUpDownVerticesNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewGraph = new System.Windows.Forms.ListView();
            this.columnHeaderOrigin = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDestination = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderWeight = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.buttonDijkstra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxDestinationVertex = new System.Windows.Forms.ComboBox();
            this.comboBoxOriginVertex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesNumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(700, 700);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // labelRemainingVertices
            // 
            this.labelRemainingVertices.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRemainingVertices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(79)))));
            this.labelRemainingVertices.Location = new System.Drawing.Point(12, 715);
            this.labelRemainingVertices.Name = "labelRemainingVertices";
            this.labelRemainingVertices.Size = new System.Drawing.Size(700, 49);
            this.labelRemainingVertices.TabIndex = 1;
            this.labelRemainingVertices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(718, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(842, 78);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Algoritmo de Dijkstra";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreateVertices);
            this.groupBox1.Controls.Add(this.numericUpDownVerticesNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(731, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 214);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación de Vértices";
            // 
            // buttonCreateVertices
            // 
            this.buttonCreateVertices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.buttonCreateVertices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateVertices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateVertices.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateVertices.Location = new System.Drawing.Point(10, 115);
            this.buttonCreateVertices.Name = "buttonCreateVertices";
            this.buttonCreateVertices.Size = new System.Drawing.Size(520, 80);
            this.buttonCreateVertices.TabIndex = 2;
            this.buttonCreateVertices.Text = "Añadir Vértices";
            this.buttonCreateVertices.UseVisualStyleBackColor = false;
            this.buttonCreateVertices.Click += new System.EventHandler(this.buttonCreateVertices_Click);
            // 
            // numericUpDownVerticesNumber
            // 
            this.numericUpDownVerticesNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownVerticesNumber.Location = new System.Drawing.Point(459, 51);
            this.numericUpDownVerticesNumber.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownVerticesNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownVerticesNumber.Name = "numericUpDownVerticesNumber";
            this.numericUpDownVerticesNumber.Size = new System.Drawing.Size(68, 32);
            this.numericUpDownVerticesNumber.TabIndex = 1;
            this.numericUpDownVerticesNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecciona la cantidad de vértices del grafo: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(731, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 44);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aristas del Grafo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewGraph
            // 
            this.listViewGraph.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrigin,
            this.columnHeaderDestination,
            this.columnHeaderWeight});
            this.listViewGraph.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewGraph.Location = new System.Drawing.Point(731, 369);
            this.listViewGraph.Name = "listViewGraph";
            this.listViewGraph.Size = new System.Drawing.Size(539, 141);
            this.listViewGraph.TabIndex = 5;
            this.listViewGraph.UseCompatibleStateImageBehavior = false;
            this.listViewGraph.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrigin
            // 
            this.columnHeaderOrigin.Text = "Origen";
            this.columnHeaderOrigin.Width = 180;
            // 
            // columnHeaderDestination
            // 
            this.columnHeaderDestination.Text = "Destino";
            this.columnHeaderDestination.Width = 180;
            // 
            // columnHeaderWeight
            // 
            this.columnHeaderWeight.Text = "Distancia";
            this.columnHeaderWeight.Width = 180;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(1276, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 417);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualización del Grafo";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.treeView.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView.ForeColor = System.Drawing.Color.LavenderBlush;
            this.treeView.Location = new System.Drawing.Point(6, 26);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(272, 385);
            this.treeView.TabIndex = 0;
            // 
            // buttonDijkstra
            // 
            this.buttonDijkstra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(109)))));
            this.buttonDijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDijkstra.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDijkstra.Location = new System.Drawing.Point(13, 104);
            this.buttonDijkstra.Name = "buttonDijkstra";
            this.buttonDijkstra.Size = new System.Drawing.Size(802, 86);
            this.buttonDijkstra.TabIndex = 7;
            this.buttonDijkstra.Text = "Mostrar Camino Más Corto";
            this.buttonDijkstra.UseVisualStyleBackColor = false;
            this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxDestinationVertex);
            this.groupBox3.Controls.Add(this.comboBoxOriginVertex);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonDijkstra);
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(718, 516);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 196);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selección de vértices";
            // 
            // comboBoxDestinationVertex
            // 
            this.comboBoxDestinationVertex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestinationVertex.FormattingEnabled = true;
            this.comboBoxDestinationVertex.Location = new System.Drawing.Point(448, 57);
            this.comboBoxDestinationVertex.Name = "comboBoxDestinationVertex";
            this.comboBoxDestinationVertex.Size = new System.Drawing.Size(276, 32);
            this.comboBoxDestinationVertex.TabIndex = 11;
            // 
            // comboBoxOriginVertex
            // 
            this.comboBoxOriginVertex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOriginVertex.FormattingEnabled = true;
            this.comboBoxOriginVertex.Location = new System.Drawing.Point(111, 57);
            this.comboBoxOriginVertex.Name = "comboBoxOriginVertex";
            this.comboBoxOriginVertex.Size = new System.Drawing.Size(260, 32);
            this.comboBoxOriginVertex.TabIndex = 10;
            this.comboBoxOriginVertex.SelectedIndexChanged += new System.EventHandler(this.comboBoxOriginVertex_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecciona Vértice de Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecciona Vértice de Origen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1572, 773);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listViewGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelRemainingVertices);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo de Dijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesNumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private Label labelRemainingVertices;
        private Label labelTitle;
        private GroupBox groupBox1;
        private Button buttonCreateVertices;
        private NumericUpDown numericUpDownVerticesNumber;
        private Label label3;
        private Label label4;
        private ListView listViewGraph;
        private GroupBox groupBox2;
        private TreeView treeView;
        private Button buttonDijkstra;
        private GroupBox groupBox3;
        private ComboBox comboBoxDestinationVertex;
        private ComboBox comboBoxOriginVertex;
        private Label label2;
        private Label label1;
        private ColumnHeader columnHeaderOrigin;
        private ColumnHeader columnHeaderDestination;
        private ColumnHeader columnHeaderWeight;
    }
}