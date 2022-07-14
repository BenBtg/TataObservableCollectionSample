using System.Collections.Generic;
using System.Windows.Input;
using ObservableCollectionSample.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace ObservableCollectionSample.ViewModels
{
    public class CollectionGroup : List<Item>
    {
        public string Header { get; private set; }

        public CollectionGroup(string header, List<Item> items) : base(items)
        {
            Header = header;
        }
    }

    public class CollectionViewModel
    {
        public ICommand RefreshCommand => new Command(Refresh);

        public ObservableRangeCollection<CollectionGroup> ItemGroups { get; set; } = new ObservableRangeCollection<CollectionGroup>();

        List<Item> list1;
        List<Item> list2;

        public CollectionViewModel()
        {
            list1 = new List<Item>
            {
                new Item
                {
                    Text = "Item 1",
                    Description = "Description of item 1"
                },
                new Item
                {
                    Text = "Item 2",
                    Description = "Description of item 2"
                }
            };
            list2 = new List<Item>
            {
               new Item
                {
                    Text = "Item 1",
                    Description = "Description of item 1"
                },
                new Item
                {
                    Text = "Item 2",
                    Description = "Description of item 2"
                }
            };
            ItemGroups.AddRange(new List<CollectionGroup>
            {
                new CollectionGroup("Header 1", list1),
                new CollectionGroup("Header 2", list2)
            });
        }

        void Refresh()
        {
            list1.Add(new Item
            {
                Text = "Item " + (list1.Count + 1),
                Description = "Description of item " + (list1.Count + 1)
            });
            list2.Add(new Item
            {
                Text = "Item " + (list2.Count + 1),
                Description = "Description of item"  + (list2.Count + 1)
            });
            ItemGroups.Clear();
            ItemGroups.AddRange(new List<CollectionGroup>
            {
                new CollectionGroup("Header 1", list1),
                new CollectionGroup("Header 2", list2)
            });
        }

    }
}
