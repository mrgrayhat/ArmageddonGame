using System;
using Armageddon.Models.Base.Interfaces;
using Armageddon.Models.Base.Types;
using Armageddon.Models.Extensions;

namespace Armageddon.Models.Base
{
    /// <summary>
    /// base class for all of the unit's in the game.
    /// </summary>
    public abstract class UnitBase : IUnitBase
    {

        #region Private Fields
        // unit fields and some default values

        private long _id = Guid.NewGuid().ToByteArray().GetHashCode();
        private double _damageTaken = 0d;
        private double _attackSpeed = 1d;
        private double _criticalAttackChance = 1d;
        private double _defenseArmor = 1d;
        private double _cost = 0d;
        private bool _isEnabled = true;
        private bool _isAlive = true;
        private double _attackDamage = 1d;
        private double _health = 50d;
        private string _name;
        private UnitTypesEnum _unitType;

        #endregion
        
        
        #region Public Properties

        /// <summary>
        /// unit unique id
        /// </summary>
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// unit name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public UnitTypesEnum UnitType
        {
            get { return _unitType; }
            set { _unitType = value; }
        }
        /// <summary>
        /// Unit Health/Life. 
        /// if the value is negative, it becomes Zero(0)
        /// </summary>
        public double Health
        {
            get { return _health; }
            set
            {
                // if the value is negative, it becomes Zero(0).
                // (for example more damage than unit health)

                if (Math.Max(0, value) == 0)
                {
                    _isAlive = false;
                    _health = 0; return;
                }
                _health = value;
            }
        }
        public double AttackDamage
        {
            get { return _attackDamage; }
            set { _attackDamage = value; }
        }
        /// <summary>
        /// unit hits (taken damage)
        /// </summary>
        public double DamageTaken
        {
            get { return _damageTaken; }
            set
            {
                // a percent damage based on armor
                _damageTaken = value - (value * (_defenseArmor * 0.01d));
                Health -= _damageTaken;
            }
        }
        /// <summary>
        /// check alive / death status
        /// </summary>
        public bool IsAlive
        {
            get
            {
                //_isAlive = _damageTaken < _health;
                return _isAlive;
            }
            set
            {
                _isAlive = value;
            }
        }
        /// <summary>
        /// unit cost
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        /// <summary>
        /// unit attack speed
        /// </summary>
        public double AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }
        /// <summary>
        /// critical chance(1x, 2x, etc)
        /// </summary>
        public double CriticalAttackChance
        {
            get { return _criticalAttackChance; }
            set { _criticalAttackChance = value; }
        }
        /// <summary>
        /// unit armor (used when taking damage)
        /// </summary>
        public double DefenseArmor
        {
            get { return _defenseArmor; }
            set { _defenseArmor = value; }
        }
        /// <summary>
        /// enable / disable unit status
        /// </summary>
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { _isEnabled = value; }
        }

        #endregion

        #region Constructors

        public UnitBase()
        {

        }

        public UnitBase(long id, string name, UnitTypesEnum unitType, double health, double defenseArmor, double damageTaken, double attackDammage, double attackSpeed, double criticalAttackChance, int cost, bool isEnabled)
        {
            ID = id;
            Name = name;
            UnitType = unitType;
            Health = health;
            DefenseArmor = defenseArmor;
            AttackDamage = attackDammage;
            AttackSpeed = attackSpeed;
            CriticalAttackChance = criticalAttackChance;
            Cost = cost;
            IsEnabled = isEnabled;
        }

        #endregion
    }
}
