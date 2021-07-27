using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCamouflaged
{
    public partial class CamouflageWindow : Form
    {


        public CamouflageWindow()
        {
            InitializeComponent();
            this.messagelabel.Text = "Kamufle etmek istediğiniz göseli seçiniz.";
            this.messagelabel.ForeColor = System.Drawing.Color.SteelBlue;
        }


        private void ButtonClickfile(object sender, EventArgs a)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Image Files(*.JPEG;*.JPG*;.PNG;*.SVG)|*.JPEG;*.JPG;*.PNG;*.SVG";

            var dialogResult = File.ShowDialog();

            if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
            {
                Bitmap image = new Bitmap(File.FileName);

                ImageBefore.Image = image;

                Bitmap CamouflagedImage = CamouflageImage(in image);

                Bitmap GreyI = Grey(in image);//kamufle edilmiş halini gri seviyeye getirmek için imCamouflagedImage

                ImageAfter.Image = CamouflagedImage;
                ImageGrey.Image = GreyI;

                this.messagelabel.Text = "    >>>>  Görüntü Kamufle Edildi  <<<<";
                this.messagelabel.ForeColor = System.Drawing.Color.Orange;

            }
            else
            {
                this.messagelabel.Text = "     -->  Görsel seçimi yapmadınız  <--";
                this.messagelabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            }
        }


        private void ColorMix(Bitmap image, List<BitmapRowDetail> borderpointList, List<Color> colors)
        {
            Random random = new Random();

            for (int i = 0; i < borderpointList.Count; i++)
            {
                for (int j = borderpointList[i].StartColum; j < borderpointList[i].EndColum; j++)
                {
                    var randomdeger = random.Next(0, colors.Count());

                    image.SetPixel(i, j, colors[randomdeger]);
                }
            }
        }


        private Bitmap CamouflageImage(in Bitmap image)
        {
            Bitmap CImage = image.Clone() as Bitmap;

            List<Color> differentColors = GetDifferentColorsListBitmap(CImage, 10);
            List<BitmapRowDetail> borderCoordinateL = GetBorderPoints(CImage);

            ColorMix(CImage, borderCoordinateL, differentColors);

            return CImage;
        }


        private Bitmap Grey(in Bitmap image)
        {

            Bitmap grey = image.Clone() as Bitmap;
            Color colordata;
            byte greydata, red, green, blue;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    colordata = image.GetPixel(i, j);
                    red = colordata.R;
                    green = colordata.G;
                    blue = colordata.B;

                    greydata = Convert.ToByte((red + green + blue) / 3);
                    grey.SetPixel(i, j, Color.FromArgb(greydata, greydata, greydata));
                }
            }
            return grey;

        }


        private List<BitmapRowDetail> GetBorderPoints(Bitmap image)
        {
            List<BitmapRowDetail> borderpointList = new List<BitmapRowDetail>();

            for (int i = 1; i < image.Width - 1; i++)
            {
                BitmapRowDetail RowDetail = new BitmapRowDetail();

                RowDetail.Row = i;

                for (int j = 1; j < image.Height - 1; j++)
                {
                    Color ColorLeft = image.GetPixel(i - 1, j);
                    Color ColorRight = image.GetPixel(i + 1, j);
                    Color ColorUp = image.GetPixel(i, j - 1);
                    Color ColorDown = image.GetPixel(i, j + 1);
                    int dx = ColorRight.R - ColorLeft.R;
                    int dy = ColorDown.R - ColorUp.R;
                    double Precision = Math.Sqrt(dx * dx / 4 + dy * dy / 4);

                    if (Precision > 9)//0b1010
                    {
                        if (RowDetail.StartColum == 0)
                        {
                            RowDetail.StartColum = j;
                        }
                        else
                        {
                            RowDetail.EndColum = j;
                        }
                    }
                }

                borderpointList.Add(RowDetail);
            }

            return borderpointList;

        }


        private List<Color> GetDifferentColorsListBitmap(Bitmap image, int count)
        {
            List<Color> colorsIm = new List<Color>();

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    var colorIm = image.GetPixel(x, y);
                    colorsIm.Add(colorIm);
                }
            }

            return colorsIm
                .GroupBy(k => k)
                .Select(groupIm => new
                {
                    Key = groupIm.Key,
                    Count = groupIm.Count()
                })
                .OrderByDescending(k => k.Count)
                .Take(count)
                .Select(k => k.Key)
                .ToList();
        }

    }


    class BitmapRowDetail
    {
        public int Row { get; set; }
        public int StartColum { get; set; }
        public int EndColum { get; set; }
    }


}
