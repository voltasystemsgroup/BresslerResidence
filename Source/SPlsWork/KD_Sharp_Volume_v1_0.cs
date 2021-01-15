using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_KD_SHARP_VOLUME_V1_0
{
    public class UserModuleClass_KD_SHARP_VOLUME_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DN;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_OUT;
        private void VOLUME (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 49;
            TX__DOLLAR__  .UpdateValue ( "VOLM" + Functions.ItoA (  (int) ( _SplusNVRAM.I ) ) + "  \r"  ) ; 
            __context__.SourceCodeLine = 50;
            VOLUME_OUT  .Value = (ushort) ( _SplusNVRAM.I ) ; 
            
            }
            
        private void MUTE_OFF_F (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 55;
            TX__DOLLAR__  .UpdateValue ( "MUTE2   \r"  ) ; 
            
            }
            
        object VOLUME_UP_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 65;
                MUTE_OFF_F (  __context__  ) ; 
                __context__.SourceCodeLine = 67;
                while ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUME_UP  .Value == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 69;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.I < 60 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 71;
                        _SplusNVRAM.I = (ushort) ( (_SplusNVRAM.I + 1) ) ; 
                        __context__.SourceCodeLine = 72;
                        VOLUME (  __context__  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 74;
                    Functions.Delay (  (int) ( 10 ) ) ; 
                    __context__.SourceCodeLine = 67;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUME_DN_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 81;
            MUTE_OFF_F (  __context__  ) ; 
            __context__.SourceCodeLine = 83;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (VOLUME_DN  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 85;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.I >= 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 87;
                    _SplusNVRAM.I = (ushort) ( (_SplusNVRAM.I - 1) ) ; 
                    __context__.SourceCodeLine = 88;
                    VOLUME (  __context__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 90;
                Functions.Delay (  (int) ( 10 ) ) ; 
                __context__.SourceCodeLine = 83;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 100;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 101;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.I > 60 ) ) || Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.I == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 103;
            _SplusNVRAM.I = (ushort) ( 25 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_UP__DigitalInput__, VOLUME_UP );
    
    VOLUME_DN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DN__DigitalInput__, VOLUME_DN );
    
    VOLUME_OUT = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_OUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_OUT__AnalogSerialOutput__, VOLUME_OUT );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    
    VOLUME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnPush_0, false ) );
    VOLUME_DN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_DN_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_KD_SHARP_VOLUME_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VOLUME_UP__DigitalInput__ = 0;
const uint VOLUME_DN__DigitalInput__ = 1;
const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint VOLUME_OUT__AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort I = 0;
            
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
