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

            List<BuyImage> listofimages = new List<BuyImage>();
            foreach (var file in files)
            {
                BuyImage image = new BuyImage();
                image._id = file.Id.ToString();
                image.Data = await imagestore.DownloadAsBytesAsync(file.Id);
                
            }

            return listofimages;

        }


    }
}
