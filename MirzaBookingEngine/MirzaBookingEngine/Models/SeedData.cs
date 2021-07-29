using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MirzaBookingEngine.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BookingEngineDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookingEngineDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Room.Any())
            {
                context.Room.AddRange(
                    new Room
                    {
                        RoomProperty = "The Honor Motel",
                        Description = "Our king size four poster provides views over landscaped gardens. It has a seating area, ample storage, digital safe, minibar and luxurious duck down bedding." +
                        "Our king size sleigh bedded also provides views over landscaped gardens. It has ample storage, a seating area, digital safe, minibar and luxurious duck down bedding." +
                        " These rooms have been recently refurbished and are fully ensuite with toilet, shower and bath and toileteries. Also available in the room is Tea and Coffee making Facilities," +
                        " Flat Screen TV, Hairdryer and Free Wifi. Iron and ironing board available upon request.",
                        Price = 680,
                        IsRoomAvailable = true
                    },
                  new Room
                  {
                      RoomProperty = "The Honor Motel",
                      Description = "Our king size four poster provides views over landscaped gardens. It has a seating area, ample storage, digital safe, minibar and luxurious duck down bedding." +
                    "Our king size sleigh bedded also provides views over landscaped gardens. It has ample storage, a seating area, digital safe, minibar and luxurious duck down bedding." +
                    " These rooms have been recently refurbished and are fully ensuite with toilet, shower and bath and toileteries. Also available in the room is Tea and Coffee making Facilities," +
                    " Flat Screen TV, Hairdryer and Free Wifi. Iron and ironing board available upon request.",
                      Price = 115,
                      IsRoomAvailable = true
                  },
                  new Room
                  {
                      RoomProperty = "The Honor Motel",
                      Description = "Our king size four poster provides views over landscaped gardens. It has a seating area, ample storage, digital safe, minibar and luxurious duck down bedding." +
                    "Our king size sleigh bedded also provides views over landscaped gardens. It has ample storage, a seating area, digital safe, minibar and luxurious duck down bedding." +
                    " These rooms have been recently refurbished and are fully ensuite with toilet, shower and bath and toileteries. Also available in the room is Tea and Coffee making Facilities," +
                    " Flat Screen TV, Hairdryer and Free Wifi. Iron and ironing board available upon request.",
                      Price = 275,
                      IsRoomAvailable = true
                  },
                  new Room
                  {
                      RoomProperty = "The Honor Motel",
                      Description = "Our king size four poster provides views over landscaped gardens. It has a seating area, ample storage, digital safe, minibar and luxurious duck down bedding." +
                    "Our king size sleigh bedded also provides views over landscaped gardens. It has ample storage, a seating area, digital safe, minibar and luxurious duck down bedding." +
                    " These rooms have been recently refurbished and are fully ensuite with toilet, shower and bath and toileteries. Also available in the room is Tea and Coffee making Facilities," +
                    " Flat Screen TV, Hairdryer and Free Wifi. Iron and ironing board available upon request.",
                      Price = 199,
                      IsRoomAvailable = true
                  },
                  new Room
                  {
                      RoomProperty = "The Honor Motel",
                      Description = "Our king size four poster provides views over landscaped gardens. It has a seating area, ample storage, digital safe, minibar and luxurious duck down bedding." +
                    "Our king size sleigh bedded also provides views over landscaped gardens. It has ample storage, a seating area, digital safe, minibar and luxurious duck down bedding." +
                    " These rooms have been recently refurbished and are fully ensuite with toilet, shower and bath and toileteries. Also available in the room is Tea and Coffee making Facilities," +
                    " Flat Screen TV, Hairdryer and Free Wifi. Iron and ironing board available upon request.",
                      Price = 300,
                      IsRoomAvailable = true
                  },
                  new Room
                  {
                      RoomProperty = "The Honor Motel",
                      Description = "Our king size four poster provides views over landscaped gardens. It has a seating area, ample storage, digital safe, minibar and luxurious duck down bedding." +
                    "Our king size sleigh bedded also provides views over landscaped gardens. It has ample storage, a seating area, digital safe, minibar and luxurious duck down bedding." +
                    " These rooms have been recently refurbished and are fully ensuite with toilet, shower and bath and toileteries. Also available in the room is Tea and Coffee making Facilities," +
                    " Flat Screen TV, Hairdryer and Free Wifi. Iron and ironing board available upon request.",
                      Price = 1100,
                      IsRoomAvailable = true
                  }
                );
                context.SaveChanges();
            }
        }
    }
}
