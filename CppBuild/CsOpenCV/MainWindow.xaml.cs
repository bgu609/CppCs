﻿using System.Windows;
using OpencvCLR;
using OpenCvSharp;

namespace CsOpenCV
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        ClrImage clrimage = new ClrImage();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void image_button_Click(object sender, RoutedEventArgs e)
        {
            clrimage.openimage();
        }
    }
}
