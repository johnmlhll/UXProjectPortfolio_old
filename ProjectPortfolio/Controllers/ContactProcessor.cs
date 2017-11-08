using System;
using System.Web.Mvc;
using ProjectPortfolio.Models;
using System.Xml;
using System.Xml.Linq;
using System.Web.Hosting;

namespace ProjectPortfolio.Controllers
{
    public class ContactProcessor
    {
        /// <summary>
        /// Class Definition: Class processes data inputed on the Contact John online form and stores in XML DB.
        /// </summary>

        //Declare Variables
        private string filePath = "~/App_Data/contact.xml";

        /**
         * Method 1 - Determine if first file and post  
         */
        public bool PostToXMLDB(ContactModel contact) 
        {
            bool validEntry = false;
            if (System.IO.File.Exists(HostingEnvironment.MapPath(filePath)))
            {
                validEntry = PostXMLEntry(contact);
            }
            else
            {
                validEntry = PostFirstXMLEntry(contact);  
            }
            return validEntry;
        } 

        /**
         * Method 2 - Declare new XML DB and Process First Contact Instance Save to XML DB
         */
        private bool PostFirstXMLEntry(ContactModel contact)
        {
            bool validEntry = false;
            try
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(HostingEnvironment.MapPath(filePath)))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Contact");
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                    //load first entry
                    XDocument contactMessage = XDocument.Load(HostingEnvironment.MapPath(filePath));
                    XElement contactEntry = contactMessage.Element("Contact");
                    contactEntry.Add(
                        new XElement("ContactEntry",
                                     new XElement("Date", DateTime.Now),
                                     new XElement("FirstName", contact.FirstName),
                                     new XElement("LastName", contact.LastName),
                                     new XElement("Phone", contact.PhoneNumber),
                                     new XElement("Email", contact.Email),
                                     new XElement("CompanyName", contact.CompanyName),
                                     new XElement("City", contact.City),
                                     new XElement("Country", contact.Country),
                                     new XElement("ContactType", contact.ContactReason),
                                     new XElement("Message", contact.Message)
                                    )
                    );
                    contactEntry.Save(HostingEnvironment.MapPath(filePath));
                    validEntry = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurred on First XML DB Write. Details are {0}", e.Message);
                return validEntry;
            }

            return validEntry;
        }

        /**
         * Method 3 - Add XML to existing XML DB
         */
        private bool PostXMLEntry(ContactModel contact)
        {
            bool validEntry = false;
            try
            {
                XDocument contactMessage = XDocument.Load(HostingEnvironment.MapPath(filePath));
                XElement contactEntry = contactMessage.Element("Contact");
                contactEntry.Add(
                    new XElement("ContactEntry",
                                 new XElement("Date", DateTime.Now),
                                 new XElement("FirstName", contact.FirstName),
                                 new XElement("LastName", contact.LastName),
                                 new XElement("Phone", contact.PhoneNumber),
                                 new XElement("Email", contact.Email),
                                 new XElement("CompanyName", contact.CompanyName),
                                 new XElement("City", contact.City),
                                 new XElement("Country", contact.Country),
                                 new XElement("ContactType", contact.ContactReason),
                                 new XElement("Message", contact.Message)
                                )
                );
                contactEntry.Save(HostingEnvironment.MapPath(filePath));
                validEntry = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurred in XML DB Write to existing DB. Details are {0}", e.Message);
                return validEntry;
            }
            return validEntry;
        }
    }
}
