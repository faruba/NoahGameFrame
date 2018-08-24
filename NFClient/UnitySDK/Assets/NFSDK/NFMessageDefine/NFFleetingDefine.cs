//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NFFleetingDefine.proto
namespace NFFS
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FSVector3")]
  public partial class FSVector3 : global::ProtoBuf.IExtensible
  {
    public FSVector3() {}
    
    private float _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FixTimeEvent")]
  public partial class FixTimeEvent : global::ProtoBuf.IExtensible
  {
    public FixTimeEvent() {}
    
    private readonly global::System.Collections.Generic.List<NFFS.FixTimeEvent.HitTrigger> _hitTrigger = new global::System.Collections.Generic.List<NFFS.FixTimeEvent.HitTrigger>();
    [global::ProtoBuf.ProtoMember(1, Name=@"hitTrigger", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.FixTimeEvent.HitTrigger> hitTrigger
    {
      get { return _hitTrigger; }
    }
  
    private readonly global::System.Collections.Generic.List<NFFS.FixTimeEvent.EventTrigger> _eventTrigger = new global::System.Collections.Generic.List<NFFS.FixTimeEvent.EventTrigger>();
    [global::ProtoBuf.ProtoMember(5, Name=@"eventTrigger", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.FixTimeEvent.EventTrigger> eventTrigger
    {
      get { return _eventTrigger; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventTrigger")]
  public partial class EventTrigger : global::ProtoBuf.IExtensible
  {
    public EventTrigger() {}
    
    private float _eventTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"eventTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float eventTime
    {
      get { return _eventTime; }
      set { _eventTime = value; }
    }
    private NFFS.FSVector3 _v;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"v", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFFS.FSVector3 v
    {
      get { return _v; }
      set { _v = value; }
    }
    private string _prefab;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"prefab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string prefab
    {
      get { return _prefab; }
      set { _prefab = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HitTrigger")]
  public partial class HitTrigger : global::ProtoBuf.IExtensible
  {
    public HitTrigger() {}
    
    private float _hitTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"hitTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float hitTime
    {
      get { return _hitTime; }
      set { _hitTime = value; }
    }
    private string _prefab;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"prefab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string prefab
    {
      get { return _prefab; }
      set { _prefab = value; }
    }
    private float _backHeroDis;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"backHeroDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float backHeroDis
    {
      get { return _backHeroDis; }
      set { _backHeroDis = value; }
    }
    private float _backNpcDis;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"backNpcDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float backNpcDis
    {
      get { return _backNpcDis; }
      set { _backNpcDis = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BulletEvent")]
  public partial class BulletEvent : global::ProtoBuf.IExtensible
  {
    public BulletEvent() {}
    
    private readonly global::System.Collections.Generic.List<NFFS.BulletEvent.Bullet> _bulletList = new global::System.Collections.Generic.List<NFFS.BulletEvent.Bullet>();
    [global::ProtoBuf.ProtoMember(1, Name=@"bulletList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.BulletEvent.Bullet> bulletList
    {
      get { return _bulletList; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TacheBomp")]
  public partial class TacheBomp : global::ProtoBuf.IExtensible
  {
    public TacheBomp() {}
    
    private float _bompTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bompTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float bompTime
    {
      get { return _bompTime; }
      set { _bompTime = value; }
    }
    private float _bompRang;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"bompRang", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float bompRang
    {
      get { return _bompRang; }
      set { _bompRang = value; }
    }
    private string _bompPrefabPath;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"bompPrefabPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string bompPrefabPath
    {
      get { return _bompPrefabPath; }
      set { _bompPrefabPath = value; }
    }
    private string _beAttackParticle;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"beAttackParticle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string beAttackParticle
    {
      get { return _beAttackParticle; }
      set { _beAttackParticle = value; }
    }
    private float _backNpcDis;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"backNpcDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float backNpcDis
    {
      get { return _backNpcDis; }
      set { _backNpcDis = value; }
    }
    private float _backHeroDis;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"backHeroDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float backHeroDis
    {
      get { return _backHeroDis; }
      set { _backHeroDis = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Bullet")]
  public partial class Bullet : global::ProtoBuf.IExtensible
  {
    public Bullet() {}
    
    private float _eventTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"eventTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float eventTime
    {
      get { return _eventTime; }
      set { _eventTime = value; }
    }
    private NFFS.BulletEvent.EBEType _eventType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"eventType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFFS.BulletEvent.EBEType eventType
    {
      get { return _eventType; }
      set { _eventType = value; }
    }
    private float _speed;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"speed", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float speed
    {
      get { return _speed; }
      set { _speed = value; }
    }
    private float _maxDis;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"maxDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float maxDis
    {
      get { return _maxDis; }
      set { _maxDis = value; }
    }
    private float _bulletRang;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"bulletRang", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float bulletRang
    {
      get { return _bulletRang; }
      set { _bulletRang = value; }
    }
    private NFFS.BulletEvent.EBE_BACKType _bulletBackType;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"bulletBackType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFFS.BulletEvent.EBE_BACKType bulletBackType
    {
      get { return _bulletBackType; }
      set { _bulletBackType = value; }
    }
    private float _backHeroDis;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"backHeroDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float backHeroDis
    {
      get { return _backHeroDis; }
      set { _backHeroDis = value; }
    }
    private float _backNpcDis;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"backNpcDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float backNpcDis
    {
      get { return _backNpcDis; }
      set { _backNpcDis = value; }
    }
    private int _tacheDetroy;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"tacheDetroy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tacheDetroy
    {
      get { return _tacheDetroy; }
      set { _tacheDetroy = value; }
    }
    private string _beAttackParticle;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"beAttackParticle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string beAttackParticle
    {
      get { return _beAttackParticle; }
      set { _beAttackParticle = value; }
    }
    private NFFS.FSVector3 _fireOffest;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"fireOffest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFFS.FSVector3 fireOffest
    {
      get { return _fireOffest; }
      set { _fireOffest = value; }
    }
    private string _bulletPrefabPath;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"bulletPrefabPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string bulletPrefabPath
    {
      get { return _bulletPrefabPath; }
      set { _bulletPrefabPath = value; }
    }
    private NFFS.BulletEvent.TacheBomp _bomp;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"bomp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFFS.BulletEvent.TacheBomp bomp
    {
      get { return _bomp; }
      set { _bomp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EBEType")]
    public enum EBEType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESET_TARGET", Value=0)]
      ESET_TARGET = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ESET_POSITION", Value=1)]
      ESET_POSITION = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EBE_BACKType")]
    public enum EBE_BACKType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBEBT_BACK", Value=0)]
      EBEBT_BACK = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EBEBT_SIDE", Value=1)]
      EBEBT_SIDE = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AudioEvent")]
  public partial class AudioEvent : global::ProtoBuf.IExtensible
  {
    public AudioEvent() {}
    
    private readonly global::System.Collections.Generic.List<NFFS.AudioEvent.Audio> _audioList = new global::System.Collections.Generic.List<NFFS.AudioEvent.Audio>();
    [global::ProtoBuf.ProtoMember(1, Name=@"audioList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.AudioEvent.Audio> audioList
    {
      get { return _audioList; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Audio")]
  public partial class Audio : global::ProtoBuf.IExtensible
  {
    public Audio() {}
    
    private float _eventTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"eventTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float eventTime
    {
      get { return _eventTime; }
      set { _eventTime = value; }
    }
    private string _audioPrefabName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"audioPrefabName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string audioPrefabName
    {
      get { return _audioPrefabName; }
      set { _audioPrefabName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MoveEvent")]
  public partial class MoveEvent : global::ProtoBuf.IExtensible
  {
    public MoveEvent() {}
    
    private readonly global::System.Collections.Generic.List<NFFS.MoveEvent.Move> _moveEvent = new global::System.Collections.Generic.List<NFFS.MoveEvent.Move>();
    [global::ProtoBuf.ProtoMember(1, Name=@"moveEvent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.MoveEvent.Move> moveEvent
    {
      get { return _moveEvent; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Move")]
  public partial class Move : global::ProtoBuf.IExtensible
  {
    public Move() {}
    
    private float _eventTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"eventTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float eventTime
    {
      get { return _eventTime; }
      set { _eventTime = value; }
    }
    private NFFS.MoveEvent.METype _eventType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"eventType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFFS.MoveEvent.METype eventType
    {
      get { return _eventType; }
      set { _eventType = value; }
    }
    private float _moveDis;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"moveDis", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float moveDis
    {
      get { return _moveDis; }
      set { _moveDis = value; }
    }
    private float _moveTime;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"moveTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float moveTime
    {
      get { return _moveTime; }
      set { _moveTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"METype")]
    public enum METype
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ME_FORWARD", Value=0)]
      ME_FORWARD = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ME_BACK", Value=1)]
      ME_BACK = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ME_LEFT", Value=2)]
      ME_LEFT = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ME_RIGHT", Value=3)]
      ME_RIGHT = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CameraEvent")]
  public partial class CameraEvent : global::ProtoBuf.IExtensible
  {
    public CameraEvent() {}
    
    private readonly global::System.Collections.Generic.List<NFFS.CameraEvent.Camera> _cameraEventList = new global::System.Collections.Generic.List<NFFS.CameraEvent.Camera>();
    [global::ProtoBuf.ProtoMember(1, Name=@"cameraEventList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.CameraEvent.Camera> cameraEventList
    {
      get { return _cameraEventList; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Camera")]
  public partial class Camera : global::ProtoBuf.IExtensible
  {
    public Camera() {}
    
    private float _eventTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"eventTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float eventTime
    {
      get { return _eventTime; }
      set { _eventTime = value; }
    }
    private NFFS.CameraEvent.CEType _eventType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"eventType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFFS.CameraEvent.CEType eventType
    {
      get { return _eventType; }
      set { _eventType = value; }
    }
    private NFFS.FSVector3 _amountParam;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"amountParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NFFS.FSVector3 amountParam
    {
      get { return _amountParam; }
      set { _amountParam = value; }
    }
    private float _shakeTime;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"shakeTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float shakeTime
    {
      get { return _shakeTime; }
      set { _shakeTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CEType")]
    public enum CEType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Earthquake", Value=0)]
      Earthquake = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Explosion", Value=1)]
      Explosion = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"No", Value=2)]
      No = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FireKick", Value=3)]
      FireKick = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Stomp", Value=4)]
      Stomp = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Yes", Value=5)]
      Yes = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SprintShake", Value=6)]
      SprintShake = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FreeMode", Value=7)]
      FreeMode = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MainRPGMode", Value=8)]
      MainRPGMode = 8
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EnableEvents")]
  public partial class EnableEvents : global::ProtoBuf.IExtensible
  {
    public EnableEvents() {}
    
    private readonly global::System.Collections.Generic.List<NFFS.EnableEvents.Enable> _enableList = new global::System.Collections.Generic.List<NFFS.EnableEvents.Enable>();
    [global::ProtoBuf.ProtoMember(1, Name=@"enableList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.EnableEvents.Enable> enableList
    {
      get { return _enableList; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Enable")]
  public partial class Enable : global::ProtoBuf.IExtensible
  {
    public Enable() {}
    
    private float _eventTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"eventTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float eventTime
    {
      get { return _eventTime; }
      set { _eventTime = value; }
    }
    private NFFS.EnableEvents.EEETYPE _eventType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"eventType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFFS.EnableEvents.EEETYPE eventType
    {
      get { return _eventType; }
      set { _eventType = value; }
    }
    private string _targetName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"targetName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string targetName
    {
      get { return _targetName; }
      set { _targetName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EEETYPE")]
    public enum EEETYPE
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INIT", Value=0)]
      INIT = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FINAL", Value=1)]
      FINAL = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GlobalSpeed")]
  public partial class GlobalSpeed : global::ProtoBuf.IExtensible
  {
    public GlobalSpeed() {}
    
    private readonly global::System.Collections.Generic.List<NFFS.GlobalSpeed.Speed> _speedList = new global::System.Collections.Generic.List<NFFS.GlobalSpeed.Speed>();
    [global::ProtoBuf.ProtoMember(1, Name=@"speedList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFFS.GlobalSpeed.Speed> speedList
    {
      get { return _speedList; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Speed")]
  public partial class Speed : global::ProtoBuf.IExtensible
  {
    public Speed() {}
    
    private float _eventTime;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"eventTime", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float eventTime
    {
      get { return _eventTime; }
      set { _eventTime = value; }
    }
    private NFFS.GlobalSpeed.EGSTYPE _eventType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"eventType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFFS.GlobalSpeed.EGSTYPE eventType
    {
      get { return _eventType; }
      set { _eventType = value; }
    }
    private float _speedValue;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"speedValue", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float speedValue
    {
      get { return _speedValue; }
      set { _speedValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGSTYPE")]
    public enum EGSTYPE
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"INIT", Value=0)]
      INIT = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FINAL", Value=1)]
      FINAL = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}