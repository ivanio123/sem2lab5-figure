using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace sem2lab5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum FigureType { Circle, Square, Rhomb }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(FigureType.Circle);
            comboBox1.Items.Add(FigureType.Square);
            comboBox1.Items.Add(FigureType.Rhomb);
            comboBox1.SelectedItem = comboBox1.Items[0];
        } 

        private void addFigurebutton_Click(object sender, EventArgs e)
        {
            FigureType figureType = (FigureType)comboBox1.SelectedItem;
            Figure figure;
            switch (figureType)
            {
                case FigureType.Circle:                 
                    figure = new Circle(20, 200, 45);

                    Task task = new Task(() => 
                    {
                        while (true)
                        {
                            if (figure.x >= 700)
                            {                               
                                break;
                            }
                           
                            figure.MoveRight(panel1);                             

                            Thread.Sleep(100);
                            Invoke(new MethodInvoker(delegate {
                                panel1.Refresh(); 
                            }));                             
                        }
                    });
                    task.Start();
                    //task.Wait(1000);

                    break;

                case FigureType.Rhomb:
              
                    figure = new Rhomb(20, 200, 45, 45);

                    Task.Run(() =>  
                    {
                        while (true)
                        {
                            if (figure.x >= 700)
                            {
                                break;
                            }
                            figure.MoveRight(panel1);

                            Thread.Sleep(100);
                            Invoke(new MethodInvoker(delegate {
                                panel1.Refresh();
                            }));
                        }
                    });                     
                    break;

                case FigureType.Square:
                    
                    figure = new Square(20, 200, 45);
                    Task task1 = new Task(() =>
                    {
                        while (true)
                        {
                            if (figure.x >= 700)
                            {
                                break;
                            }
                            figure.MoveRight(panel1);
                            Thread.Sleep(100);
                            Invoke(new MethodInvoker(delegate {
                                panel1.Refresh();
                            }));
                        }
                    });
                    task1.Start();
                    break;

            }
        }

        
           
    }
}
