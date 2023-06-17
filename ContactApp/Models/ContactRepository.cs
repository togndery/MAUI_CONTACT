using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp.Models;
namespace ContactApp.Models
{
    public static class ContactRepository
    {
        public static List<ContatcDetails> _contacts = new List<ContatcDetails>()
        {
            new ContatcDetails{Id=1 ,Name="ALI Mo"  , Email="aaa@gmail.com" ,Phone="123456"},
            new ContatcDetails{Id = 2 ,Name="ALI Mo1"  , Email="aaa1@gmail.com" ,Phone="1234567"},
            new ContatcDetails{Id = 3,Name="ALI Mo2"  , Email="aaa2@gmail.com",Phone="1234568"},
            new ContatcDetails{Id =4, Name="ALI Mo3"  , Email="aaa3@gmail.com",Phone="12345689"}

        };

        //return all contact
        public static List<ContatcDetails> GetContacts => _contacts;

        public static ContatcDetails GetById(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                return new ContatcDetails { Id = contact.Id, Name = contact.Name, Email = contact.Email, Phone = contact.Phone };
            }
            else
            {
                return null;
            }
        }
    


        

        public static void UpdateContatcDetails(int id, ContatcDetails contatcDetails)
        {
            if (id != contatcDetails.Id) return;

            var cotnatcToUpdate = _contacts.FirstOrDefault(x =>x.Id  == id);

            if(cotnatcToUpdate != null)
            {
                cotnatcToUpdate.Name = contatcDetails.Name;
                cotnatcToUpdate.Email = contatcDetails.Email;
                
                
            }
        }


        public  static  void AddContact(ContatcDetails contatcDetails)
        {
            
            var maxId = _contacts.Max(c => c.Id);
            
            contatcDetails.Id = maxId +1;
            _contacts.Add(contatcDetails);
            
        }


        public static void DelteItemFromList(int id)
        {
            var contatctoDelete= _contacts.FirstOrDefault(x => x.Id == id);
            if(contatctoDelete != null)
            {
                _contacts.Remove(contatctoDelete);
            }
        }

        public static List<ContatcDetails> SearchItem(string Filtertext)
        {
            var result = _contacts.Where(x => x.Name.StartsWith(Filtertext, StringComparison.OrdinalIgnoreCase))?.ToList(); ;
            return result;
        }


    }
}
