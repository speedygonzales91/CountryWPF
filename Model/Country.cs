﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * This REST Call is represented by these classes:
 * https://restcountries.eu/rest/v2/all
 * 
 * Autogenerated by:
 * http://jsonutils.com/
 * 
 */

namespace CountryWPF.Model
{
    public class Currency : INotifyPropertyChanged
    { 
        private string _code;
        public string Code
        {
            get { return _code; }
            set 
            { 
                _code = value;
                OnPropertyChanged("Code");
            }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }


        private string _symbol;
        public string Symbol
        {
            get { return _symbol; }
            set 
            { 
                _symbol = value;
                OnPropertyChanged("Symbol");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Language : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _nativeName;
        public string NativeName
        {
            get { return _nativeName; }
            set 
            { 
                _nativeName = value;
                OnPropertyChanged("NativeName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    //public class Translations
    //{
    //    public string de { get; set; }
    //    public string es { get; set; }
    //    public string fr { get; set; }
    //    public string ja { get; set; }
    //    public string it { get; set; }
    //    public string br { get; set; }
    //    public string pt { get; set; }
    //    public string nl { get; set; }
    //    public string hr { get; set; }
    //    public string fa { get; set; }
    //}

    public class RegionalBloc : INotifyPropertyChanged
    {
        private string _acronym;
        public string Acronym
        {
            get { return _acronym; }
            set 
            { 
                _acronym = value;
                OnPropertyChanged("Acronym");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class Country : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }


        private IList<string> _topLevelDomain;
        public IList<string> TopLevelDomain
        {
            get { return _topLevelDomain; }
            set 
            { 
                _topLevelDomain = value;
                OnPropertyChanged("TopLevelDomain");
            }
        }


        private string _alpha2Code;
        public string Alpha2Code
        {
            get { return _alpha2Code; }
            set 
            { 
                _alpha2Code = value;
                OnPropertyChanged("Alpha2Code");
            }
        }


        private string _alpha3Code;
        public string Alpha3Code
        {
            get { return _alpha3Code; }
            set 
            { 
                _alpha3Code = value;
                OnPropertyChanged("Alpha3Code");
            }
        }


        private IList<string> _callingCodes;
        public IList<string> CallingCodes
        {
            get { return _callingCodes; }
            set 
            { 
                _callingCodes = value;
                OnPropertyChanged("CallingCodes");
            }
        }


        private string _capital;
        public string Capital
        {
            get { return _capital; }
            set 
            { 
                _capital = value;
                OnPropertyChanged("Capital");
            }
        }


        private IList<string> _altSpellings;
        public IList<string> AltSpellings
        {
            get { return _altSpellings; }
            set 
            { 
                _altSpellings = value; 
                OnPropertyChanged("AltSpellings"); }
        }

        private string _region;
        public string Region
        {
            get { return _region; }
            set 
            { 
                _region = value; 
                OnPropertyChanged("Region");
            }
        }

        private string _subregion;
        public string Subregion
        {
            get { return _subregion; }
            set 
            { 
                _subregion = value; 
                OnPropertyChanged("Subregion"); 
            }
        }

        private int _population;
        public int Population
        {
            get { return _population; }
            set 
            { 
                _population = value; 
                OnPropertyChanged("Population");
            }
        }


        private IList<double> _latlng;
        public IList<double> Latlng
        {
            get { return _latlng; }
            set 
            {
                _latlng = value;
                OnPropertyChanged("Latlng"); 
            }
        }


        private string _demonym;
        public string Demonym
        {
            get { return _demonym; }
            set 
            { 
                _demonym = value;
                OnPropertyChanged("Demonym");
            }
        }



        private double _area;
        public double Area
        {
            get { return _area; }
            set 
            { 
                _area = value; 
                OnPropertyChanged("Area");
            }
        }



        private double _gini;
        public double Gini
        {
            get { return _gini; }
            set { _gini = value; OnPropertyChanged("Gini"); }
        }


        private IList<string> _timezones;
        public IList<string> Timezones
        {
            get { return _timezones; }
            set 
            { 
                _timezones = value;
                OnPropertyChanged("Timezones");
            }
        }



        private IList<string> _borders;
        public IList<string> Borders
        {
            get { return _borders; }
            set 
            { 
                _borders = value;
                OnPropertyChanged("Borders");
            }
        }


        private string _nativeName;
        public string NativeName
        {
            get { return _nativeName; }
            set 
            { 
                _nativeName = value;
                OnPropertyChanged("NativeName");
            }
        }

        private string _numericCode;
        public string NumericCode
        {
            get { return _numericCode; }
            set 
            { 
                _numericCode = value; 
                OnPropertyChanged("NumericCode");
            }
        }



        private IList<Currency> _currencies;
        public IList<Currency> Currencies
        {
            get { return _currencies; }
            set 
            { 
                _currencies = value; 
                OnPropertyChanged("Currencies");
            }
        }


        private IList<Language> _languages;
        public IList<Language> Languages
        {
            get { return _languages; }
            set 
            { 
                _languages = value; 
                OnPropertyChanged("Languages");
            }
        }

        //public Translations translations { get; set; }

        //public string cioc { get; set; }

        private string _flag;
        public string Flag
        {
            get { return _flag; }
            set
            { 
                _flag = value;
                OnPropertyChanged("Flag");
            }
        }


        private IList<RegionalBloc> _regionalBlocs;
        public IList<RegionalBloc> RegionalBlocs
        {
            get { return _regionalBlocs; }
            set 
            {
                _regionalBlocs = value; 
                OnPropertyChanged("RegionalBlocs");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


}