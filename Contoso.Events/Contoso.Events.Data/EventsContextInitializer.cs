using Contoso.Events.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Contoso.Events.Data
{
    public class EventsContextInitializer : CreateDatabaseIfNotExists<EventsContext>
    {
        protected override void Seed(EventsContext context)
        {
            context.Events.AddRange(
                new List<Event> 
                {
                    new Event
                    {
                      EventKey = "SharePointExpertsSymposium16",
                      StartTime = new DateTime(2016, 10, 8, 11, 52, 00),
                      EndTime = new DateTime(2016, 10, 11, 11, 52, 00),
                      Title = "SharePoint Experts Symposium",
                      Description = "Sed in euismod mi, sed pellentesque tortor. Aenean ac massa dolor. Fusce in ligula a nisl lacinia fermentum a ac mi. Vivamus placerat at nunc ut egestas. Suspendisse eu diam interdum, laoreet turpis at, volutpat sem. Maecenas adipiscing fringilla orci, eget venenatis turpis pharetra a. Sed cursus neque arcu, sed malesuada nisl blandit ut. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean ac fringilla nisl. Aenean blandit tempus dignissim. Pellentesque vehicula dapibus nibh, in rutrum mi dignissim quis. Nulla condimentum ipsum vitae metus interdum, scelerisque rutrum lorem hendrerit. Phasellus tempor venenatis dolor, ac interdum mi aliquam nec. Fusce vitae felis vel odio elementum facilisis nec sed magna. Aenean scelerisque sed neque quis sodales.",
                      Location = new Location
                      {
                          Name = "Las Vegas Convention Center",
                          StreetAddress = "3150 Paradise Road",
                          City = "Las Vegas",
                          State ="NV",
                          ZipCode = "89109"
                      }
                    }
                }
            );
        }
    }
}