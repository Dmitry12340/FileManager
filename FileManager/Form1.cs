using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private string filePath = "D:";//Путь к файлу
        private bool isFile = false;//Файл или папка
        private string currentlySelectedItemName = "";//Выбранный элемент
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilePathTextBox.Text = filePath;
            LoadFilesAndDirectories();
        }

        private void LoadFilesAndDirectories()//Метод загрузки файлов и котологов
        {
            DirectoryInfo fileList;
            string tempFilePath = "";

            FileAttributes fileAttr;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;

                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    FileNameLable.Text = fileDetails.Name;
                    FileTypeLable.Text = fileDetails.Extension;

                    fileAttr = File.GetAttributes(tempFilePath);

                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);

                    FileInfo[] files = fileList.GetFiles();//Получаем список файлов
                    DirectoryInfo[] dirs = fileList.GetDirectories();//Получаем список папок

                    string fileExtension = "";

                    ListView1.Items.Clear();

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        ListView1.Items.Add(dirs[i].Name, 1);
                    }

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToLower();
                        switch (fileExtension)
                        {
                            case ".txt":
                                ListView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".png":
                                ListView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".exe":
                                ListView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".mp4":
                                ListView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".mp3":
                                ListView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".pdf":
                                ListView1.Items.Add(files[i].Name, 7);
                                break;
                            case ".doc":
                                ListView1.Items.Add(files[i].Name, 8);
                                break;
                            case ".bin":
                                ListView1.Items.Add(files[i].Name, 10);
                                break;
                            case ".dll":
                                ListView1.Items.Add(files[i].Name, 11);
                                break;
                            case ".ini":
                                ListView1.Items.Add(files[i].Name, 12);
                                break;
                            case ".dat":
                                ListView1.Items.Add(files[i].Name, 13);
                                break;
                            case ".lnk":
                                ListView1.Items.Add(files[i].Name, 14);
                                break;
                            case ".url":
                                ListView1.Items.Add(files[i].Name, 15);
                                break;
                            case ".xlsx":
                                ListView1.Items.Add(files[i].Name, 16);
                                break;
                            case ".xls":
                                ListView1.Items.Add(files[i].Name, 17);
                                break;
                            case ".jpg":
                                ListView1.Items.Add(files[i].Name, 18);
                                break;
                            case ".jpeg":
                                ListView1.Items.Add(files[i].Name, 19);
                                break;
                            case ".pptx":
                                ListView1.Items.Add(files[i].Name, 20);
                                break;
                            case ".docx":
                                ListView1.Items.Add(files[i].Name, 21);
                                break;
                            case ".sln":
                                ListView1.Items.Add(files[i].Name, 22);
                                break;
                            default:
                                ListView1.Items.Add(files[i].Name, 9);
                                break;
                        }
                    }
                }
                else
                {
                    FileNameLable.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LoadButtonAction()
        {
            removeBackSlash();
            filePath = FilePathTextBox.Text;
            LoadFilesAndDirectories();
            isFile = false;
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            LoadButtonAction();
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttributes = File.GetAttributes(filePath + "/" + currentlySelectedItemName);

            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)//Проверяем выбранный элемент является ли файлом или нет
            {
                isFile = false;
                FilePathTextBox.Text = filePath + "/" + currentlySelectedItemName;//Если это папка, то добавляем её имя к пути через слеш
            }
            else
            {
                isFile = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                removeBackSlash();
                string path = FilePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                FilePathTextBox.Text = path;
                removeBackSlash();

                LoadButtonAction();
            }
            catch (Exception ex)
            {

            }
        }


        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadButtonAction();
        }

        public void removeBackSlash()
        {
            string path = FilePathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                FilePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }
    }
}
