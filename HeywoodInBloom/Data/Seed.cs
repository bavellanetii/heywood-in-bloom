using HeywoodInBloom.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;

namespace HeywoodInBloom.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Projects.Any())
                {
                    context.Projects.AddRange(new List<Project>()
                    {
                        new Project()
                        {
                            Name = "Project 1",
                            WriteUp = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vestibulum faucibus faucibus. Donec elementum, justo sit amet congue ultricies, augue est lacinia lacus, non sagittis ligula massa nec ligula. Etiam laoreet tortor at arcu venenatis varius. Integer ultrices leo non mauris accumsan luctus. Nunc a faucibus velit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec eu quam tempor, euismod urna vel, sagittis ipsum. Donec blandit enim sed orci porta iaculis. Duis egestas nisi dictum velit eleifend, vel tincidunt magna fermentum. Nulla varius nulla in posuere euismod. Nulla ultricies finibus dolor sed convallis.\r\n\r\nNunc viverra eget erat in laoreet. In ut neque et massa mattis pellentesque. Cras posuere pharetra vehicula. Aenean sit amet lorem eu dolor laoreet porta non eu risus. Curabitur aliquet enim sit amet purus condimentum malesuada. Quisque malesuada ornare lorem, non commodo turpis lacinia sed. Vivamus sollicitudin velit quis varius viverra. Proin commodo purus neque, sit amet imperdiet magna dapibus sit amet.\r\n\r\nPhasellus sit amet elementum erat. Curabitur tempor aliquam dolor eu pellentesque. Phasellus id consectetur ante. Vivamus tincidunt justo nulla, sed laoreet lectus tristique in. Donec mattis ex quis luctus imperdiet. Nunc at dui sed ligula scelerisque dapibus nec ut sapien. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus bibendum ipsum ut eros tincidunt, sit amet ornare urna commodo. Aenean ut magna erat. Duis aliquam condimentum odio ut facilisis.",
                            ImageUrl = "assets/crystal-jo-PKcTuA_CRAo-unsplash.jpg",
                            ThumbnailUrl = "assets/crystal-jo-PKcTuA_CRAo-unsplash.jpg"
                         },
                        new Project()
                        {
                            Name = "Project 2",
                            WriteUp = "Phasellus sit amet elementum erat. Curabitur tempor aliquam dolor eu pellentesque. Phasellus id consectetur ante. Vivamus tincidunt justo nulla, sed laoreet lectus tristique in. Donec mattis ex quis luctus imperdiet. Nunc at dui sed ligula scelerisque dapibus nec ut sapien. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus bibendum ipsum ut eros tincidunt, sit amet ornare urna commodo. Aenean ut magna erat. Duis aliquam condimentum odio ut facilisis.\r\n\r\nDuis ac posuere nisl. Aenean tempor lobortis sodales. Vestibulum dictum tellus lobortis velit luctus, non ultrices risus cursus. Fusce sit amet elementum nisi. Ut tristique ipsum urna. Quisque pellentesque a libero at efficitur. Fusce in purus sed felis imperdiet varius eget vel felis. Proin vehicula at magna sit amet fringilla. Ut quis suscipit ipsum, id faucibus dui. Sed sagittis vel nunc sit amet finibus. Donec tincidunt dapibus libero quis molestie. Fusce tempor leo vitae vehicula blandit.\r\n\r\nPraesent commodo est tristique nibh rutrum, suscipit bibendum est cursus. Mauris posuere, libero quis suscipit commodo, mauris sapien iaculis arcu, volutpat luctus justo eros nec elit. Aenean nibh sapien, imperdiet vel fermentum eu, euismod non erat. Suspendisse placerat sed tortor non iaculis. Nam vitae quam non purus bibendum vestibulum. Nunc maximus congue libero non elementum. Integer ultricies fringilla commodo. Vivamus convallis felis a diam dignissim elementum.",
                            ImageUrl = "assets/jonathan-kemper-Zv68_CirpeQ-unsplash.jpg",
                            ThumbnailUrl = "assets/jonathan-kemper-Zv68_CirpeQ-unsplash.jpg"
                        },
                        new Project()
                        {
                            Name = "Project 3",
                            WriteUp = "Phasellus sit amet elementum erat. Curabitur tempor aliquam dolor eu pellentesque. Phasellus id consectetur ante. Vivamus tincidunt justo nulla, sed laoreet lectus tristique in. Donec mattis ex quis luctus imperdiet. Nunc at dui sed ligula scelerisque dapibus nec ut sapien. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vivamus bibendum ipsum ut eros tincidunt, sit amet ornare urna commodo. Aenean ut magna erat. Duis aliquam condimentum odio ut facilisis.\r\n\r\nDuis ac posuere nisl. Aenean tempor lobortis sodales. Vestibulum dictum tellus lobortis velit luctus, non ultrices risus cursus. Fusce sit amet elementum nisi. Ut tristique ipsum urna. Quisque pellentesque a libero at efficitur. Fusce in purus sed felis imperdiet varius eget vel felis. Proin vehicula at magna sit amet fringilla. Ut quis suscipit ipsum, id faucibus dui. Sed sagittis vel nunc sit amet finibus. Donec tincidunt dapibus libero quis molestie. Fusce tempor leo vitae vehicula blandit.\r\n\r\nPraesent commodo est tristique nibh rutrum, suscipit bibendum est cursus. Mauris posuere, libero quis suscipit commodo, mauris sapien iaculis arcu, volutpat luctus justo eros nec elit. Aenean nibh sapien, imperdiet vel fermentum eu, euismod non erat. Suspendisse placerat sed tortor non iaculis. Nam vitae quam non purus bibendum vestibulum. Nunc maximus congue libero non elementum. Integer ultricies fringilla commodo. Vivamus convallis felis a diam dignissim elementum.",
                            ImageUrl = "assets/markus-spiske-4PG6wLlVag4-unsplash.jpg",
                            ThumbnailUrl = "assets/markus-spiske-4PG6wLlVag4-unsplash.jpg"
                        },
                    });
                    context.SaveChanges();
                }
                //Sponsors
                if (!context.Sponsors.Any())
                {
                    context.Sponsors.AddRange(new List<Sponsor>()
                    {
                        new Sponsor()
                        {
                            Name = "Howdens Kitchens",
                            ImageUrl = "assets/Howdens-Logotype_Horizontal_BlackRed-NEW-LOGO.jpg",
                            WebsiteUrl = "https://howdens.com/"
                        },
                        new Sponsor()
                        {
                            Name = "Footasylum",
                            ImageUrl = "assets/footasylum-logo.jpg",
                            WebsiteUrl = "https://www.footasylum.com/"
                        },
                        new Sponsor()
                        {
                            Name = "Yearsleys Haulage",
                            ImageUrl = "assets/Yearsley-Food-LOGO.jpg",
                            WebsiteUrl = "https://www.yearsleyfood.co.uk/"
                        }
                    });
                    context.SaveChanges();
                }
                //TeamMember
                if (!context.TeamMembers.Any())
                {
                    context.TeamMembers.AddRange(new List<TeamMember>()
                    {
                        new TeamMember()
                        {
                            FirstName = "Ellen",
                            LastName = "Yates",
                            JobTitle = "Chair",
                            ImageUrl = "assets/ellen.jpg"
                        },
                        new TeamMember()
                        {
                            FirstName = "Rachel",
                            LastName = "Avellanet",
                            JobTitle = "Digital Administrator",
                            ImageUrl = "assets/rachel.jpg"
                        },
                        new TeamMember()
                        {
                            FirstName = "David",
                            LastName = "Yates",
                            JobTitle = "Gardener",
                            ImageUrl = "assets/dave.jpg"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

  /*      public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "ellenyates@hotmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        UserName = "ellenyates",
                        FirstName = "Ellen"
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        PhoneNumber = "07817312652"
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
  */
    }
}
