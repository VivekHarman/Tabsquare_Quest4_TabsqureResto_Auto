///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Auto_Tabsquare_Rest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Auto_Tabsquare_RestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f9e42f1e-cc0a-43dd-8ec1-0e4e1f217b0d")]
    public partial class Auto_Tabsquare_RestRepository : RepoGenBaseFolder
    {
        static Auto_Tabsquare_RestRepository instance = new Auto_Tabsquare_RestRepository();
        Auto_Tabsquare_RestRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the Auto_Tabsquare_RestRepository element repository.
        /// </summary>
        [RepositoryFolder("f9e42f1e-cc0a-43dd-8ec1-0e4e1f217b0d")]
        public static Auto_Tabsquare_RestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Auto_Tabsquare_RestRepository() 
            : base("Auto_Tabsquare_RestRepository", "/", null, 0, false, "f9e42f1e-cc0a-43dd-8ec1-0e4e1f217b0d", ".\\RepositoryImages\\Auto_Tabsquare_RestRepositoryf9e42f1e.rximgres")
        {
            _applicationundertest = new Auto_Tabsquare_RestRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

        string _CountryCode = "\\+91";

        /// <summary>
        /// Gets or sets the value of variable CountryCode.
        /// </summary>
        [TestVariable("e3a7c566-ae68-45f6-9339-2ea3013dde04")]
        public string CountryCode
        {
            get { return _CountryCode; }
            set { _CountryCode = value; }
        }

        string _Quantity = "3";

        /// <summary>
        /// Gets or sets the value of variable Quantity.
        /// </summary>
        [TestVariable("e8f1f2b1-86e8-4e03-bf3c-c4fd8805ab7d")]
        public string Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f9e42f1e-cc0a-43dd-8ec1-0e4e1f217b0d")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("38c35793-065a-474e-9755-566ce7a55b6c")]
        public virtual Auto_Tabsquare_RestRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Auto_Tabsquare_RestRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("38c35793-065a-474e-9755-566ce7a55b6c")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            Auto_Tabsquare_RestRepositoryFolders.LoginPageFolder _loginpage;
            Auto_Tabsquare_RestRepositoryFolders.HomePageFolder _homepage;
            Auto_Tabsquare_RestRepositoryFolders.OrderPageFolder _orderpage;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='smartweb-ecms.tabsquare.com']", parentFolder, 30000, null, false, "38c35793-065a-474e-9755-566ce7a55b6c", "")
            {
                _loginpage = new Auto_Tabsquare_RestRepositoryFolders.LoginPageFolder(this);
                _homepage = new Auto_Tabsquare_RestRepositoryFolders.HomePageFolder(this);
                _orderpage = new Auto_Tabsquare_RestRepositoryFolders.OrderPageFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("38c35793-065a-474e-9755-566ce7a55b6c")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("38c35793-065a-474e-9755-566ce7a55b6c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LoginPage folder.
            /// </summary>
            [RepositoryFolder("58660ed7-d03c-4fe5-88b5-54d9b150fe77")]
            public virtual Auto_Tabsquare_RestRepositoryFolders.LoginPageFolder LoginPage
            {
                get { return _loginpage; }
            }

            /// <summary>
            /// The HomePage folder.
            /// </summary>
            [RepositoryFolder("e4cd7b3a-f453-4c97-be44-061ff18300ad")]
            public virtual Auto_Tabsquare_RestRepositoryFolders.HomePageFolder HomePage
            {
                get { return _homepage; }
            }

            /// <summary>
            /// The OrderPage folder.
            /// </summary>
            [RepositoryFolder("14e605bd-261b-4f98-8c04-01616b961881")]
            public virtual Auto_Tabsquare_RestRepositoryFolders.OrderPageFolder OrderPage
            {
                get { return _orderpage; }
            }
        }

        /// <summary>
        /// The LoginPageFolder folder.
        /// </summary>
        [RepositoryFolder("58660ed7-d03c-4fe5-88b5-54d9b150fe77")]
        public partial class LoginPageFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btn_goInfo;
            RepoItemInfo _countrycodearrowInfo;
            RepoItemInfo _textbox_countrysearchInfo;
            RepoItemInfo _countrycodenameInfo;
            RepoItemInfo _textbox_mobilenumberInfo;

            /// <summary>
            /// Creates a new LoginPage  folder.
            /// </summary>
            public LoginPageFolder(RepoGenBaseFolder parentFolder) :
                    base("LoginPage", "", parentFolder, 0, null, false, "58660ed7-d03c-4fe5-88b5-54d9b150fe77", "")
            {
                _btn_goInfo = new RepoItemInfo(this, "Btn_Go", ".//button[@innertext~'Go']/tag[@tagname='svg']", "", 30000, null, "6496a024-05a1-4d83-bcde-5da57d434876");
                _countrycodearrowInfo = new RepoItemInfo(this, "CountryCodeArrow", ".//span[@class='select2-selection__arrow']", "", 30000, null, "bf39f96c-2f28-49bb-819d-2b4c950ac885");
                _textbox_countrysearchInfo = new RepoItemInfo(this, "TextBox_CountrySearch", ".//input[@type='search' and @class='select2-search__field']", "", 30000, null, "ceaa45c5-cf30-461d-86aa-610cea81b078");
                _countrycodenameInfo = new RepoItemInfo(this, "CountryCodeName", ".//li[@innertext~$CountryCode]", "", 30000, null, "21f06f2f-8025-40d8-a394-63f367f8df8a");
                _textbox_mobilenumberInfo = new RepoItemInfo(this, "TextBox_MobileNumber", ".//input[@name='mobile_no']", "", 30000, null, "7627d774-943c-4798-bf5b-01c2d31bfa2b");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("58660ed7-d03c-4fe5-88b5-54d9b150fe77")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Btn_Go item.
            /// </summary>
            [RepositoryItem("6496a024-05a1-4d83-bcde-5da57d434876")]
            public virtual Ranorex.WebElement Btn_Go
            {
                get
                {
                    return _btn_goInfo.CreateAdapter<Ranorex.WebElement>(true);
                }
            }

            /// <summary>
            /// The Btn_Go item info.
            /// </summary>
            [RepositoryItemInfo("6496a024-05a1-4d83-bcde-5da57d434876")]
            public virtual RepoItemInfo Btn_GoInfo
            {
                get
                {
                    return _btn_goInfo;
                }
            }

            /// <summary>
            /// The CountryCodeArrow item.
            /// </summary>
            [RepositoryItem("bf39f96c-2f28-49bb-819d-2b4c950ac885")]
            public virtual Ranorex.SpanTag CountryCodeArrow
            {
                get
                {
                    return _countrycodearrowInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The CountryCodeArrow item info.
            /// </summary>
            [RepositoryItemInfo("bf39f96c-2f28-49bb-819d-2b4c950ac885")]
            public virtual RepoItemInfo CountryCodeArrowInfo
            {
                get
                {
                    return _countrycodearrowInfo;
                }
            }

            /// <summary>
            /// The TextBox_CountrySearch item.
            /// </summary>
            [RepositoryItem("ceaa45c5-cf30-461d-86aa-610cea81b078")]
            public virtual Ranorex.InputTag TextBox_CountrySearch
            {
                get
                {
                    return _textbox_countrysearchInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The TextBox_CountrySearch item info.
            /// </summary>
            [RepositoryItemInfo("ceaa45c5-cf30-461d-86aa-610cea81b078")]
            public virtual RepoItemInfo TextBox_CountrySearchInfo
            {
                get
                {
                    return _textbox_countrysearchInfo;
                }
            }

            /// <summary>
            /// The CountryCodeName item.
            /// </summary>
            [RepositoryItem("21f06f2f-8025-40d8-a394-63f367f8df8a")]
            public virtual Ranorex.LiTag CountryCodeName
            {
                get
                {
                    return _countrycodenameInfo.CreateAdapter<Ranorex.LiTag>(true);
                }
            }

            /// <summary>
            /// The CountryCodeName item info.
            /// </summary>
            [RepositoryItemInfo("21f06f2f-8025-40d8-a394-63f367f8df8a")]
            public virtual RepoItemInfo CountryCodeNameInfo
            {
                get
                {
                    return _countrycodenameInfo;
                }
            }

            /// <summary>
            /// The TextBox_MobileNumber item.
            /// </summary>
            [RepositoryItem("7627d774-943c-4798-bf5b-01c2d31bfa2b")]
            public virtual Ranorex.InputTag TextBox_MobileNumber
            {
                get
                {
                    return _textbox_mobilenumberInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The TextBox_MobileNumber item info.
            /// </summary>
            [RepositoryItemInfo("7627d774-943c-4798-bf5b-01c2d31bfa2b")]
            public virtual RepoItemInfo TextBox_MobileNumberInfo
            {
                get
                {
                    return _textbox_mobilenumberInfo;
                }
            }
        }

        /// <summary>
        /// The HomePageFolder folder.
        /// </summary>
        [RepositoryFolder("e4cd7b3a-f453-4c97-be44-061ff18300ad")]
        public partial class HomePageFolder : RepoGenBaseFolder
        {
            Auto_Tabsquare_RestRepositoryFolders.AddItem__PopupFolder _additem__popup;
            Auto_Tabsquare_RestRepositoryFolders.CheckOutListFolder _checkoutlist;
            Auto_Tabsquare_RestRepositoryFolders.ItemQuantityFolder _itemquantity;
            RepoItemInfo _dineinbuttonInfo;
            RepoItemInfo _maincourselogoInfo;
            RepoItemInfo _item_riceplateInfo;
            RepoItemInfo _btn_addriceplateInfo;

            /// <summary>
            /// Creates a new HomePage  folder.
            /// </summary>
            public HomePageFolder(RepoGenBaseFolder parentFolder) :
                    base("HomePage", "", parentFolder, 0, null, false, "e4cd7b3a-f453-4c97-be44-061ff18300ad", "")
            {
                _additem__popup = new Auto_Tabsquare_RestRepositoryFolders.AddItem__PopupFolder(this);
                _checkoutlist = new Auto_Tabsquare_RestRepositoryFolders.CheckOutListFolder(this);
                _itemquantity = new Auto_Tabsquare_RestRepositoryFolders.ItemQuantityFolder(this);
                _dineinbuttonInfo = new RepoItemInfo(this, "DineInButton", ".//a[@innertext~'Dine In']", "", 30000, null, "d0fec121-8449-46bc-864f-956bb06f19ba");
                _maincourselogoInfo = new RepoItemInfo(this, "MainCourseLogo", ".//img[@src='https://storage.googleapis.com/skipque3/others/1647509687-Store_tada_5376.jpeg']", "", 30000, null, "ef1d1fbf-357f-4132-a636-3201bc8176d7");
                _item_riceplateInfo = new RepoItemInfo(this, "Item_RicePlate", ".//span[@innertext='Rice Plate']", "", 30000, null, "fb62acc9-9334-428b-926b-d8b7bf890832");
                _btn_addriceplateInfo = new RepoItemInfo(this, "Btn_AddRicePlate", ".//span[@innertext='Rice Plate']/ancestor::li/.//a[@innertext='Add        ']", "", 30000, null, "7aea1345-3137-4d5d-8711-7ec7890f8c2a");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e4cd7b3a-f453-4c97-be44-061ff18300ad")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DineInButton item.
            /// </summary>
            [RepositoryItem("d0fec121-8449-46bc-864f-956bb06f19ba")]
            public virtual Ranorex.ATag DineInButton
            {
                get
                {
                    return _dineinbuttonInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The DineInButton item info.
            /// </summary>
            [RepositoryItemInfo("d0fec121-8449-46bc-864f-956bb06f19ba")]
            public virtual RepoItemInfo DineInButtonInfo
            {
                get
                {
                    return _dineinbuttonInfo;
                }
            }

            /// <summary>
            /// The MainCourseLogo item.
            /// </summary>
            [RepositoryItem("ef1d1fbf-357f-4132-a636-3201bc8176d7")]
            public virtual Ranorex.ImgTag MainCourseLogo
            {
                get
                {
                    return _maincourselogoInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The MainCourseLogo item info.
            /// </summary>
            [RepositoryItemInfo("ef1d1fbf-357f-4132-a636-3201bc8176d7")]
            public virtual RepoItemInfo MainCourseLogoInfo
            {
                get
                {
                    return _maincourselogoInfo;
                }
            }

            /// <summary>
            /// The Item_RicePlate item.
            /// </summary>
            [RepositoryItem("fb62acc9-9334-428b-926b-d8b7bf890832")]
            public virtual Ranorex.SpanTag Item_RicePlate
            {
                get
                {
                    return _item_riceplateInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The Item_RicePlate item info.
            /// </summary>
            [RepositoryItemInfo("fb62acc9-9334-428b-926b-d8b7bf890832")]
            public virtual RepoItemInfo Item_RicePlateInfo
            {
                get
                {
                    return _item_riceplateInfo;
                }
            }

            /// <summary>
            /// The Btn_AddRicePlate item.
            /// </summary>
            [RepositoryItem("7aea1345-3137-4d5d-8711-7ec7890f8c2a")]
            public virtual Ranorex.ATag Btn_AddRicePlate
            {
                get
                {
                    return _btn_addriceplateInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Btn_AddRicePlate item info.
            /// </summary>
            [RepositoryItemInfo("7aea1345-3137-4d5d-8711-7ec7890f8c2a")]
            public virtual RepoItemInfo Btn_AddRicePlateInfo
            {
                get
                {
                    return _btn_addriceplateInfo;
                }
            }

            /// <summary>
            /// The AddItem__Popup folder.
            /// </summary>
            [RepositoryFolder("9fada421-58cf-4e6f-b639-638a716b3a8a")]
            public virtual Auto_Tabsquare_RestRepositoryFolders.AddItem__PopupFolder AddItem__Popup
            {
                get { return _additem__popup; }
            }

            /// <summary>
            /// The CheckOutList folder.
            /// </summary>
            [RepositoryFolder("69a8f6e4-de80-475b-8359-fa0df09d9e8f")]
            public virtual Auto_Tabsquare_RestRepositoryFolders.CheckOutListFolder CheckOutList
            {
                get { return _checkoutlist; }
            }

            /// <summary>
            /// The ItemQuantity folder.
            /// </summary>
            [RepositoryFolder("be469425-d681-4651-975e-3a97f93b5902")]
            public virtual Auto_Tabsquare_RestRepositoryFolders.ItemQuantityFolder ItemQuantity
            {
                get { return _itemquantity; }
            }
        }

        /// <summary>
        /// The AddItem__PopupFolder folder.
        /// </summary>
        [RepositoryFolder("9fada421-58cf-4e6f-b639-638a716b3a8a")]
        public partial class AddItem__PopupFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btn_addInfo;

            /// <summary>
            /// Creates a new AddItem__Popup  folder.
            /// </summary>
            public AddItem__PopupFolder(RepoGenBaseFolder parentFolder) :
                    base("AddItem__Popup", ".//div[@id='skuContainer']", parentFolder, 30000, null, false, "9fada421-58cf-4e6f-b639-638a716b3a8a", "")
            {
                _btn_addInfo = new RepoItemInfo(this, "Btn_Add", ".//a[@innertext~'Add ']", "", 30000, null, "f6af77e2-0d5f-44d4-b555-dc9159ee839a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9fada421-58cf-4e6f-b639-638a716b3a8a")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9fada421-58cf-4e6f-b639-638a716b3a8a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Btn_Add item.
            /// </summary>
            [RepositoryItem("f6af77e2-0d5f-44d4-b555-dc9159ee839a")]
            public virtual Ranorex.ATag Btn_Add
            {
                get
                {
                    return _btn_addInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Btn_Add item info.
            /// </summary>
            [RepositoryItemInfo("f6af77e2-0d5f-44d4-b555-dc9159ee839a")]
            public virtual RepoItemInfo Btn_AddInfo
            {
                get
                {
                    return _btn_addInfo;
                }
            }
        }

        /// <summary>
        /// The CheckOutListFolder folder.
        /// </summary>
        [RepositoryFolder("69a8f6e4-de80-475b-8359-fa0df09d9e8f")]
        public partial class CheckOutListFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new CheckOutList  folder.
            /// </summary>
            public CheckOutListFolder(RepoGenBaseFolder parentFolder) :
                    base("CheckOutList", ".//a[#'checkoutButton']", parentFolder, 30000, null, false, "69a8f6e4-de80-475b-8359-fa0df09d9e8f", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("69a8f6e4-de80-475b-8359-fa0df09d9e8f")]
            public virtual Ranorex.ATag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("69a8f6e4-de80-475b-8359-fa0df09d9e8f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The ItemQuantityFolder folder.
        /// </summary>
        [RepositoryFolder("be469425-d681-4651-975e-3a97f93b5902")]
        public partial class ItemQuantityFolder : RepoGenBaseFolder
        {
            RepoItemInfo _quantityInfo;
            RepoItemInfo _quantity_plusbtnInfo;

            /// <summary>
            /// Creates a new ItemQuantity  folder.
            /// </summary>
            public ItemQuantityFolder(RepoGenBaseFolder parentFolder) :
                    base("ItemQuantity", ".//ul[@class='btn-dish add-action']", parentFolder, 30000, null, false, "be469425-d681-4651-975e-3a97f93b5902", "")
            {
                _quantityInfo = new RepoItemInfo(this, "Quantity", ".//div[@innertext=$Quantity]", "", 30000, null, "e33e49c4-c0b9-4e1c-b39a-c7bca0b6b3c5");
                _quantity_plusbtnInfo = new RepoItemInfo(this, "Quantity_PlusBtn", ".//a[@class='to-plus btn-primary test']", "", 30000, null, "12a108c8-b1ca-4672-84de-2a9b04f994a2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("be469425-d681-4651-975e-3a97f93b5902")]
            public virtual Ranorex.UlTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.UlTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("be469425-d681-4651-975e-3a97f93b5902")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Quantity item.
            /// </summary>
            [RepositoryItem("e33e49c4-c0b9-4e1c-b39a-c7bca0b6b3c5")]
            public virtual Ranorex.DivTag Quantity
            {
                get
                {
                    return _quantityInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Quantity item info.
            /// </summary>
            [RepositoryItemInfo("e33e49c4-c0b9-4e1c-b39a-c7bca0b6b3c5")]
            public virtual RepoItemInfo QuantityInfo
            {
                get
                {
                    return _quantityInfo;
                }
            }

            /// <summary>
            /// The Quantity_PlusBtn item.
            /// </summary>
            [RepositoryItem("12a108c8-b1ca-4672-84de-2a9b04f994a2")]
            public virtual Ranorex.ATag Quantity_PlusBtn
            {
                get
                {
                    return _quantity_plusbtnInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Quantity_PlusBtn item info.
            /// </summary>
            [RepositoryItemInfo("12a108c8-b1ca-4672-84de-2a9b04f994a2")]
            public virtual RepoItemInfo Quantity_PlusBtnInfo
            {
                get
                {
                    return _quantity_plusbtnInfo;
                }
            }
        }

        /// <summary>
        /// The OrderPageFolder folder.
        /// </summary>
        [RepositoryFolder("14e605bd-261b-4f98-8c04-01616b961881")]
        public partial class OrderPageFolder : RepoGenBaseFolder
        {
            Auto_Tabsquare_RestRepositoryFolders.CartListFolder _cartlist;
            RepoItemInfo _btn_paybycashInfo;
            RepoItemInfo _ordermessageInfo;
            RepoItemInfo _orderidInfo;
            RepoItemInfo _loadingitemInfo;

            /// <summary>
            /// Creates a new OrderPage  folder.
            /// </summary>
            public OrderPageFolder(RepoGenBaseFolder parentFolder) :
                    base("OrderPage", "", parentFolder, 0, null, false, "14e605bd-261b-4f98-8c04-01616b961881", "")
            {
                _cartlist = new Auto_Tabsquare_RestRepositoryFolders.CartListFolder(this);
                _btn_paybycashInfo = new RepoItemInfo(this, "Btn_PayByCash", ".//a[@innertext~'Pay By Cash']", "", 30000, null, "331ca896-19f4-417f-a3b3-f71bf5a6cf21");
                _ordermessageInfo = new RepoItemInfo(this, "OrderMessage", ".//p[@innertext='Your Order has been successfully sent to kitchen' and @visible='True']", "", 30000, null, "b649fe1c-7114-40db-b687-5700af100ed6");
                _orderidInfo = new RepoItemInfo(this, "OrderID", ".//td[@innertext~'Order ID']", "", 30000, null, "2064fa39-c71b-45c9-879a-c5d2c050c908");
                _loadingitemInfo = new RepoItemInfo(this, "LoadingItem", ".//div[@class='loading-scroll' and @visible='True']", "", 30000, null, "cee13007-6b2f-44b8-88bf-6d67d33c4ce0");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("14e605bd-261b-4f98-8c04-01616b961881")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Btn_PayByCash item.
            /// </summary>
            [RepositoryItem("331ca896-19f4-417f-a3b3-f71bf5a6cf21")]
            public virtual Ranorex.ATag Btn_PayByCash
            {
                get
                {
                    return _btn_paybycashInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Btn_PayByCash item info.
            /// </summary>
            [RepositoryItemInfo("331ca896-19f4-417f-a3b3-f71bf5a6cf21")]
            public virtual RepoItemInfo Btn_PayByCashInfo
            {
                get
                {
                    return _btn_paybycashInfo;
                }
            }

            /// <summary>
            /// The OrderMessage item.
            /// </summary>
            [RepositoryItem("b649fe1c-7114-40db-b687-5700af100ed6")]
            public virtual Ranorex.PTag OrderMessage
            {
                get
                {
                    return _ordermessageInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The OrderMessage item info.
            /// </summary>
            [RepositoryItemInfo("b649fe1c-7114-40db-b687-5700af100ed6")]
            public virtual RepoItemInfo OrderMessageInfo
            {
                get
                {
                    return _ordermessageInfo;
                }
            }

            /// <summary>
            /// The OrderID item.
            /// </summary>
            [RepositoryItem("2064fa39-c71b-45c9-879a-c5d2c050c908")]
            public virtual Ranorex.TdTag OrderID
            {
                get
                {
                    return _orderidInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The OrderID item info.
            /// </summary>
            [RepositoryItemInfo("2064fa39-c71b-45c9-879a-c5d2c050c908")]
            public virtual RepoItemInfo OrderIDInfo
            {
                get
                {
                    return _orderidInfo;
                }
            }

            /// <summary>
            /// The LoadingItem item.
            /// </summary>
            [RepositoryItem("cee13007-6b2f-44b8-88bf-6d67d33c4ce0")]
            public virtual Ranorex.DivTag LoadingItem
            {
                get
                {
                    return _loadingitemInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The LoadingItem item info.
            /// </summary>
            [RepositoryItemInfo("cee13007-6b2f-44b8-88bf-6d67d33c4ce0")]
            public virtual RepoItemInfo LoadingItemInfo
            {
                get
                {
                    return _loadingitemInfo;
                }
            }

            /// <summary>
            /// The CartList folder.
            /// </summary>
            [RepositoryFolder("85215f90-d0e7-4d07-91af-bf7d7f15006e")]
            public virtual Auto_Tabsquare_RestRepositoryFolders.CartListFolder CartList
            {
                get { return _cartlist; }
            }
        }

        /// <summary>
        /// The CartListFolder folder.
        /// </summary>
        [RepositoryFolder("85215f90-d0e7-4d07-91af-bf7d7f15006e")]
        public partial class CartListFolder : RepoGenBaseFolder
        {
            RepoItemInfo _itemriceplaceInfo;
            RepoItemInfo _quantiyInfo;

            /// <summary>
            /// Creates a new CartList  folder.
            /// </summary>
            public CartListFolder(RepoGenBaseFolder parentFolder) :
                    base("CartList", ".//ul[@class='cart-list']", parentFolder, 30000, null, false, "85215f90-d0e7-4d07-91af-bf7d7f15006e", "")
            {
                _itemriceplaceInfo = new RepoItemInfo(this, "ItemRicePlace", ".//a[@innertext~'Rice Plate']", "", 30000, null, "fc264acb-37f8-4677-b4fa-f9ae14678dbf");
                _quantiyInfo = new RepoItemInfo(this, "Quantiy", ".//div[@innertext=$Quantity]", "", 30000, null, "bcd2bdb8-c6c8-4534-ab88-410e60ebad8b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("85215f90-d0e7-4d07-91af-bf7d7f15006e")]
            public virtual Ranorex.UlTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.UlTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("85215f90-d0e7-4d07-91af-bf7d7f15006e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ItemRicePlace item.
            /// </summary>
            [RepositoryItem("fc264acb-37f8-4677-b4fa-f9ae14678dbf")]
            public virtual Ranorex.ATag ItemRicePlace
            {
                get
                {
                    return _itemriceplaceInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ItemRicePlace item info.
            /// </summary>
            [RepositoryItemInfo("fc264acb-37f8-4677-b4fa-f9ae14678dbf")]
            public virtual RepoItemInfo ItemRicePlaceInfo
            {
                get
                {
                    return _itemriceplaceInfo;
                }
            }

            /// <summary>
            /// The Quantiy item.
            /// </summary>
            [RepositoryItem("bcd2bdb8-c6c8-4534-ab88-410e60ebad8b")]
            public virtual Ranorex.DivTag Quantiy
            {
                get
                {
                    return _quantiyInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Quantiy item info.
            /// </summary>
            [RepositoryItemInfo("bcd2bdb8-c6c8-4534-ab88-410e60ebad8b")]
            public virtual RepoItemInfo QuantiyInfo
            {
                get
                {
                    return _quantiyInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
