using System;
using AltV.Net.Data;
using AltV.Net.Elements.Args;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace AltV.Net.ColShape.Tests
{
    public class MockVehicle : IVehicle
    {
        public IntPtr NativePointer { get; }
        public bool Exists { get; }
        public BaseObjectType Type { get; }
        public void SetMetaData(string key, object value)
        {
            throw new NotImplementedException();
        }

        public bool GetMetaData<T>(string key, out T result)
        {
            throw new NotImplementedException();
        }

        public void SetMetaData(string key, ref MValue value)
        {
            throw new NotImplementedException();
        }

        public void GetMetaData(string key, ref MValue value)
        {
            throw new NotImplementedException();
        }

        public void SetData(string key, object value)
        {
            throw new NotImplementedException();
        }

        public bool GetData<T>(string key, out T result)
        {
            throw new NotImplementedException();
        }

        public void CheckIfEntityExists()
        {
            throw new NotImplementedException();
        }

        public Position Position { get; set; }
        public short Dimension { get; set; }
        public ushort Id { get; }
        public Rotation Rotation { get; set; }
        public uint Model { get; }
        public void SetSyncedMetaData(string key, object value)
        {
            throw new NotImplementedException();
        }

        public bool GetSyncedMetaData<T>(string key, out T result)
        {
            throw new NotImplementedException();
        }

        public void SetSyncedMetaData(string key, ref MValue value)
        {
            throw new NotImplementedException();
        }

        public void GetSyncedMetaData(string key, ref MValue value)
        {
            throw new NotImplementedException();
        }

        public IPlayer Driver { get; }
        public byte ModKit { get; set; }
        public byte ModKitsCount { get; }
        public bool IsPrimaryColorRgb { get; }
        public byte PrimaryColor { get; set; }
        public Rgba PrimaryColorRgb { get; set; }
        public bool IsSecondaryColorRgb { get; }
        public byte SecondaryColor { get; set; }
        public Rgba SecondaryColorRgb { get; set; }
        public byte PearlColor { get; set; }
        public byte WheelColor { get; set; }
        public byte InteriorColor { get; set; }
        public byte DashboardColor { get; set; }
        public bool IsTireSmokeColorCustom { get; }
        public Rgba TireSmokeColor { get; set; }
        public byte WheelType { get; }
        public byte WheelVariation { get; }
        public bool CustomTires { get; set; }
        public byte SpecialDarkness { get; set; }
        public uint NumberplateIndex { get; set; }
        public string NumberplateText { get; set; }
        public byte WindowTint { get; set; }
        public byte DirtLevel { get; set; }
        public Rgba NeonColor { get; set; }
        public string AppearanceData { get; set; }
        public byte GetMod(byte category)
        {
            throw new NotImplementedException();
        }

        public byte GetModsCount(byte category)
        {
            throw new NotImplementedException();
        }

        public bool SetMod(byte category, byte id)
        {
            throw new NotImplementedException();
        }

        public void SetWheels(byte type, byte variation)
        {
            throw new NotImplementedException();
        }

        public bool IsExtraOn(byte extraId)
        {
            throw new NotImplementedException();
        }

        public void ToggleExtra(byte extraId, bool state)
        {
            throw new NotImplementedException();
        }

        public bool IsNeonActive { get; }
        public void GetNeonActive(ref bool left, ref bool right, ref bool top, ref bool back)
        {
            throw new NotImplementedException();
        }

        public void SetNeonActive(bool left, bool right, bool top, bool back)
        {
            throw new NotImplementedException();
        }

        public bool EngineOn { get; set; }
        public bool IsHandbrakeActive { get; }
        public byte HeadlightColor { get; set; }
        public uint RadioStation { get; set; }
        public bool SirenActive { get; set; }
        public VehicleLockState LockState { get; set; }
        public byte GetDoorState(byte doorId)
        {
            throw new NotImplementedException();
        }

        public void SetDoorState(byte doorId, byte state)
        {
            throw new NotImplementedException();
        }

        public bool IsWindowOpened(byte windowId)
        {
            throw new NotImplementedException();
        }

        public void SetWindowOpened(byte windowId, bool state)
        {
            throw new NotImplementedException();
        }

        public bool IsDaylightOn { get; }
        public bool IsNightlightOn { get; }
        public bool RoofOpened { get; set; }
        public bool IsFlamethrowerActive { get; }
        public string State { get; set; }
        public int EngineHealth { get; set; }
        public int PetrolTankHealth { get; set; }
        public byte WheelsCount { get; }
        public bool IsWheelBurst(byte wheelId)
        {
            throw new NotImplementedException();
        }

        public void SetWheelBurst(byte wheelId, bool state)
        {
            throw new NotImplementedException();
        }

        public bool DoesWheelHasTire(byte wheelId)
        {
            throw new NotImplementedException();
        }

        public void SetWheelHasTire(byte wheelId, bool state)
        {
            throw new NotImplementedException();
        }

        public float GetWheelHealth(byte wheelId)
        {
            throw new NotImplementedException();
        }

        public void SetWheelHealth(byte wheelId, float health)
        {
            throw new NotImplementedException();
        }

        public byte RepairsCount { get; }
        public uint BodyHealth { get; set; }
        public uint BodyAdditionalHealth { get; set; }
        public string HealthData { get; set; }
        public byte GetPartDamageLevel(byte partId)
        {
            throw new NotImplementedException();
        }

        public void SetPartDamageLevel(byte partId, byte damage)
        {
            throw new NotImplementedException();
        }

        public byte GetPartBulletHoles(byte partId)
        {
            throw new NotImplementedException();
        }

        public void SetPartBulletHoles(byte partId, byte shootsCount)
        {
            throw new NotImplementedException();
        }

        public bool IsLightDamaged(byte lightId)
        {
            throw new NotImplementedException();
        }

        public void SetLightDamaged(byte lightId, bool isDamaged)
        {
            throw new NotImplementedException();
        }

        public bool IsWindowDamaged(byte windowId)
        {
            throw new NotImplementedException();
        }

        public void SetWindowDamaged(byte windowId, bool isDamaged)
        {
            throw new NotImplementedException();
        }

        public bool IsSpecialLightDamaged(byte specialLightId)
        {
            throw new NotImplementedException();
        }

        public void SetSpecialLightDamaged(byte specialLightId, bool isDamaged)
        {
            throw new NotImplementedException();
        }

        public bool HasArmoredWindows { get; }
        public float GetArmoredWindowHealth(byte windowId)
        {
            throw new NotImplementedException();
        }

        public void SetArmoredWindowHealth(byte windowId, float health)
        {
            throw new NotImplementedException();
        }

        public byte GetArmoredWindowShootCount(byte windowId)
        {
            throw new NotImplementedException();
        }

        public void SetArmoredWindowShootCount(byte windowId, byte count)
        {
            throw new NotImplementedException();
        }

        public byte GetBumperDamageLevel(byte bumperId)
        {
            throw new NotImplementedException();
        }

        public void SetBumperDamageLevel(byte bumperId, byte damageLevel)
        {
            throw new NotImplementedException();
        }

        public byte Livery { get; set; }
        public byte RoofLivery { get; set; }
        public float LightsMultiplier { get; set; }

        public string DamageData { get; set; }
        public bool ManualEngineControl { get; set; }
        public string ScriptData { get; set; }
        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void OnRemove()
        {
            throw new NotImplementedException();
        }
    }
}