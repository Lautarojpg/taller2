namespace Practico4
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            LBLista = new ListBox();
            LLista = new Label();
            LDesde = new Label();
            LHasta = new Label();
            TDesde = new TextBox();
            THasta = new TextBox();
            BPares = new Button();
            panel1 = new Panel();
            BPrimos = new Button();
            BImpares = new Button();
            BFuncion = new Button();
            LGrafica = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // LBLista
            // 
            LBLista.FormattingEnabled = true;
            LBLista.Location = new Point(282, 99);
            LBLista.Name = "LBLista";
            LBLista.Size = new Size(292, 264);
            LBLista.TabIndex = 0;
            // 
            // LLista
            // 
            LLista.AutoSize = true;
            LLista.Location = new Point(355, 63);
            LLista.Name = "LLista";
            LLista.Size = new Size(124, 20);
            LLista.TabIndex = 1;
            LLista.Text = "Lista de Numeros";
            // 
            // LDesde
            // 
            LDesde.AutoSize = true;
            LDesde.BackColor = SystemColors.ButtonShadow;
            LDesde.Location = new Point(4, 6);
            LDesde.Name = "LDesde";
            LDesde.Size = new Size(54, 20);
            LDesde.TabIndex = 2;
            LDesde.Text = "Desde:";
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Location = new Point(8, 63);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(50, 20);
            LHasta.TabIndex = 3;
            LHasta.Text = "Hasta:";
            // 
            // TDesde
            // 
            TDesde.Location = new Point(75, 3);
            TDesde.Name = "TDesde";
            TDesde.Size = new Size(125, 27);
            TDesde.TabIndex = 4;
            // 
            // THasta
            // 
            THasta.Location = new Point(75, 60);
            THasta.Name = "THasta";
            THasta.Size = new Size(125, 27);
            THasta.TabIndex = 5;
            // 
            // BPares
            // 
            BPares.Location = new Point(51, 153);
            BPares.Name = "BPares";
            BPares.Size = new Size(149, 29);
            BPares.TabIndex = 6;
            BPares.Text = "Numeros Pares";
            BPares.UseVisualStyleBackColor = true;
            BPares.Click += BPares_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(LDesde);
            panel1.Controls.Add(TDesde);
            panel1.Controls.Add(THasta);
            panel1.Controls.Add(LHasta);
            panel1.Controls.Add(BPrimos);
            panel1.Controls.Add(BImpares);
            panel1.Controls.Add(BFuncion);
            panel1.Controls.Add(BPares);
            panel1.Location = new Point(12, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 265);
            panel1.TabIndex = 8;
            // 
            // BPrimos
            // 
            BPrimos.Location = new Point(51, 223);
            BPrimos.Name = "BPrimos";
            BPrimos.Size = new Size(149, 29);
            BPrimos.TabIndex = 9;
            BPrimos.Text = "Numeros Primos";
            BPrimos.UseVisualStyleBackColor = true;
            BPrimos.Click += BPrimos_Click;
            // 
            // BImpares
            // 
            BImpares.Location = new Point(51, 188);
            BImpares.Name = "BImpares";
            BImpares.Size = new Size(149, 29);
            BImpares.TabIndex = 8;
            BImpares.Text = "Numeros Impares";
            BImpares.UseVisualStyleBackColor = true;
            BImpares.Click += BImpares_Click;
            // 
            // BFuncion
            // 
            BFuncion.Location = new Point(51, 117);
            BFuncion.Name = "BFuncion";
            BFuncion.Size = new Size(149, 29);
            BFuncion.TabIndex = 7;
            BFuncion.Text = "Generar Funcion";
            BFuncion.UseVisualStyleBackColor = true;
            BFuncion.Click += BFuncion_Click;
            // 
            // LGrafica
            // 
            LGrafica.AutoSize = true;
            LGrafica.Location = new Point(731, 21);
            LGrafica.Name = "LGrafica";
            LGrafica.Size = new Size(141, 20);
            LGrafica.TabIndex = 10;
            LGrafica.Text = "Grafica de Numeros";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(603, 44);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(375, 375);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 450);
            Controls.Add(chart1);
            Controls.Add(LGrafica);
            Controls.Add(LLista);
            Controls.Add(LBLista);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Formulario 4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LBLista;
        private Label LLista;
        private Label LDesde;
        private Label LHasta;
        private TextBox TDesde;
        private TextBox THasta;
        private Button BPares;
        private Panel panel1;
        private Button BFuncion;
        private Button BPrimos;
        private Button BImpares;
        private Label LGrafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
