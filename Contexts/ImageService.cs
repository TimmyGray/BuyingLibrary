using BuyingLibrary.models.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.Contexts
{
    public class ImageService
    {
        private readonly GridFSBucket imagestore;
        public ImageService(MongoContext context) 
        {
            imagestore = context.Imagestore;
        
        }


        public async Task<List<BuyImage>> GetAllAsync()
        {

            var files = await imagestore.Find("{}").ToListAsync();
            Console.WriteLine("Files count");
            Console.WriteLine(files.Count);

            List<BuyImage> listofimages = new List<BuyImage>();
            foreach (var file in files)
            {
                BuyImage image = new BuyImage();
                image._id = file.Id.ToString();

                Console.WriteLine("image id to string:");
                Console.WriteLine(file.Id.ToString());

                image.Data = await imagestore.DownloadAsBytesAsync(file.Id);

                Console.WriteLine("Leght of data image");
                
                Console.WriteLine(image.Data.Length);
                listofimages.Add(image);
            }

            Console.WriteLine("Counts of added images");
            Console.WriteLine(listofimages.Count);
            return listofimages;

        }


    }
}
