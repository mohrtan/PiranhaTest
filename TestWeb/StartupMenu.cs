using Piranha.Manager;

namespace PiranhaTest
{
    public class StartupMenu
    {
        public static void RegisterCustomMenuItems()
        {
            Menu.Items.Add(new Menu.MenuItem()
            {
                InternalId = "PropertyManager",
                Name = "Properties",
                Css = "glyphicon glyphicon-home",
                Policy = Permission.Config,
                Items = new Menu.MenuItemList() {
                    new Menu.MenuItem() {
                        InternalId = "AllProperties",
                        Name = "All Properties",
                        Controller = "Properties",
                        Action = "PropertyList",
                        Policy = Permission.Config,
                        Css = "glyphicon glyphicon-star-empty"
                    }
                }
            });
        }
    }
}
