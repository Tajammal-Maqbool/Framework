using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Framework_07
{
    internal class TilesGrid
    {
        private int tileWidth;
        private int tileHeight;
        private string filePath;
        private string imagesFolderPath;
        private Form gameForm;
        private List<List<Tile>> allTiles = new List<List<Tile>>();
        private List<List<string>> allImages = new List<List<string>>();
        internal TilesGrid(int tileWidth, int tileHeight, Form gameForm, string filePath, string imagesFolderPath)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.gameForm = gameForm;
            this.filePath = filePath;
            this.imagesFolderPath = imagesFolderPath;
            string file;
            try
            {
                file = File.ReadAllText(this.filePath);
                file = file.Replace(Environment.NewLine, ".");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("This Path of File is Invalid");
                file = "Empty,Empty,Empty,Empty.Empty,Empty,Empty";
            }
            string image = "";
            List<string> images = new List<string>();
            for (int idx = 0; idx < file.Length; idx++)
            {
                if (file[idx] != ',' && file[idx] != '.')
                {
                    image += file[idx];
                }
                if (file[idx] == ',')
                {
                    images.Add(image);
                    image = "";
                }
                else if (file[idx] == '.' || idx == file.Length - 1)
                {
                    images.Add(image);
                    this.allImages.Add(images);
                    images = new List<string>();
                    image = "";
                }
            }
        }
        internal void addTilesToGrid()
        {
            int x = 0;
            int y = 0;
            foreach (List<string> imagesList in allImages)
            {
                x = 0;
                List<Tile> tiles = new List<Tile>();
                foreach (string image in imagesList)
                {
                    if (image != "Empty")
                    {
                        string path = "";
                        if (File.Exists($"{this.imagesFolderPath}/{image}.png"))
                        {
                            path = $"{this.imagesFolderPath}/{image}.png";
                        }
                        else if (File.Exists($"{this.imagesFolderPath}/{image}.jpg"))
                        {
                            path = $"{this.imagesFolderPath}/{image}.jpg";
                        }
                        if (path != "")
                        {
                            Tile tile = new Tile(x * tileWidth, y * tileHeight, this.tileWidth, this.tileHeight, path, gameForm);
                            tiles.Add(tile);
                        }
                    }
                    x++;
                }
                y++;
                allTiles.Add(tiles);
                tiles = new List<Tile>();
            }
        }
    }
}
