using System.Collections;
using System.ComponentModel.Design;
using System.Globalization;
using Newtonsoft.Json;
using System.Linq;

namespace Module3HM2;

public class ContactList<TName> : JsonConfig, IEnumerable, IComparable<ContactList<TName>>
{
    private CultureInfo ukrainianCulture = new CultureInfo("ua-UA", false);
    private CultureInfo englishCulture = new CultureInfo("en-US", false);
    [JsonProperty("Contacts")] private List<string> contacts;
    public List<string> othercontacts;
    public List<string> ukrainiancontacts;
    public List<string> englishcontacts;
    public List<string> onlynumberscontacts;
    public List<string> Contacts
    {
        get => contacts;
        set => contacts.Concat(othercontacts).Concat(ukrainiancontacts).Concat(englishcontacts).Concat(onlynumberscontacts);
    }


    [JsonProperty("name")] public TName _fullName;
    public void CreateContact(TName fullname)
    {
        fullname = _fullName;
    }
    
    public void UkrainianContacts(TName fullname)
    {
        fullname = _fullName;
        foreach (var person in contacts)
        {
            if (fullname != null && fullname.ToString().ToUpper().StartsWith(UkrainianFile().ToString()))
            {
                ukrainiancontacts.Add(person);
            }
            else
            {
                othercontacts.Add(person);
            }
        }
    }
    public void EnglishContacts(TName fullname)
    {
        fullname = _fullName;
        foreach (var person in contacts)
        {
            if (fullname != null && fullname.ToString().ToUpper().StartsWith(EnglishFile().ToString()))
            {
                englishcontacts.Add(person);
            }
            else
            {
                othercontacts.Add(person);
            }
        }
    }
    public void OnlyNumbersContacts(TName fullname)
    {
        fullname = _fullName;
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        foreach (var person in contacts)
        {
            if (fullname != null && fullname.ToString().ToUpper().StartsWith(numbers.ToString()))
            {
                onlynumberscontacts.Add(person);
            }
            else
            {
                othercontacts.Add(person);
            }
        }
    }

    public int SortByLetterAscending(ContactList<string> letter1, ContactList<string> letter2)
    {
        return letter1.CompareTo(letter2);
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public override bool Read()
    {
        throw new NotImplementedException();
    }

    public int CompareTo(ContactList<TName>? other)
    {
        throw new NotImplementedException();
    }
}

