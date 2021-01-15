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

namespace UserModule_SHARP_LC_52D64U_PROCESSOR_V1_0
{
    public class UserModuleClass_SHARP_LC_52D64U_PROCESSOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput KP0;
        Crestron.Logos.SplusObjects.DigitalInput KP1;
        Crestron.Logos.SplusObjects.DigitalInput KP2;
        Crestron.Logos.SplusObjects.DigitalInput KP3;
        Crestron.Logos.SplusObjects.DigitalInput KP4;
        Crestron.Logos.SplusObjects.DigitalInput KP5;
        Crestron.Logos.SplusObjects.DigitalInput KP6;
        Crestron.Logos.SplusObjects.DigitalInput KP7;
        Crestron.Logos.SplusObjects.DigitalInput KP8;
        Crestron.Logos.SplusObjects.DigitalInput KP9;
        Crestron.Logos.SplusObjects.DigitalInput KP_DOT;
        Crestron.Logos.SplusObjects.DigitalInput KP_CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput KP_ENTER;
        Crestron.Logos.SplusObjects.DigitalInput AIR;
        Crestron.Logos.SplusObjects.DigitalInput CABLE;
        Crestron.Logos.SplusObjects.StringOutput NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort ALOC = 0;
        CrestronString SNUMBER;
        CrestronString SCHANNELF;
        CrestronString SCHANNELR;
        object KP0_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 123;
                MakeString ( SNUMBER , "{0}0", SNUMBER ) ; 
                __context__.SourceCodeLine = 124;
                NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object KP1_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 129;
            MakeString ( SNUMBER , "{0}1", SNUMBER ) ; 
            __context__.SourceCodeLine = 130;
            NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KP2_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        MakeString ( SNUMBER , "{0}2", SNUMBER ) ; 
        __context__.SourceCodeLine = 136;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP3_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 141;
        MakeString ( SNUMBER , "{0}3", SNUMBER ) ; 
        __context__.SourceCodeLine = 142;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP4_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 147;
        MakeString ( SNUMBER , "{0}4", SNUMBER ) ; 
        __context__.SourceCodeLine = 148;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP5_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 153;
        MakeString ( SNUMBER , "{0}5", SNUMBER ) ; 
        __context__.SourceCodeLine = 154;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP6_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 159;
        MakeString ( SNUMBER , "{0}6", SNUMBER ) ; 
        __context__.SourceCodeLine = 160;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP7_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 165;
        MakeString ( SNUMBER , "{0}7", SNUMBER ) ; 
        __context__.SourceCodeLine = 166;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP8_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 171;
        MakeString ( SNUMBER , "{0}8", SNUMBER ) ; 
        __context__.SourceCodeLine = 172;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP9_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        MakeString ( SNUMBER , "{0}9", SNUMBER ) ; 
        __context__.SourceCodeLine = 178;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP_DOT_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 183;
        ALOC = (ushort) ( Functions.Find( "." , SNUMBER ) ) ; 
        __context__.SourceCodeLine = 184;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALOC == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 186;
            MakeString ( SNUMBER , "{0}.", SNUMBER ) ; 
            __context__.SourceCodeLine = 187;
            NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP_CLEAR_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 193;
        Functions.ClearBuffer ( SNUMBER ) ; 
        __context__.SourceCodeLine = 194;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KP_ENTER_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 200;
        ALOC = (ushort) ( Functions.Find( "." , SNUMBER ) ) ; 
        __context__.SourceCodeLine = 201;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ALOC != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 203;
            if ( Functions.TestForTrue  ( ( AIR  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 205;
                MakeString ( SCHANNELF , "{0:d2}", (short)Functions.Atoi( Functions.Left( SNUMBER , (int)( (ALOC - 1) ) ) )) ; 
                __context__.SourceCodeLine = 206;
                MakeString ( SCHANNELR , "{0:d2}", (short)Functions.Atoi( Functions.Right( SNUMBER , (int)( (Functions.Length( SNUMBER ) - ALOC) ) ) )) ; 
                __context__.SourceCodeLine = 207;
                MakeString ( TO_DEVICE__DOLLAR__ , "DA2P{0}{1}\r", SCHANNELF , SCHANNELR ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 209;
                if ( Functions.TestForTrue  ( ( CABLE  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 211;
                    MakeString ( SCHANNELF , "{0:d3}", (short)Functions.Atoi( Functions.Left( SNUMBER , (int)( (ALOC - 1) ) ) )) ; 
                    __context__.SourceCodeLine = 212;
                    MakeString ( SCHANNELR , "{0:d3}", (short)Functions.Atoi( Functions.Right( SNUMBER , (int)( (Functions.Length( SNUMBER ) - ALOC) ) ) )) ; 
                    __context__.SourceCodeLine = 213;
                    MakeString ( TO_DEVICE__DOLLAR__ , "DC2U{0} \rDC2L{1} \r", SCHANNELF , SCHANNELR ) ; 
                    } 
                
                }
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 218;
            if ( Functions.TestForTrue  ( ( AIR  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 220;
                MakeString ( SCHANNELF , "{0:d2}", (short)Functions.Atoi( SNUMBER )) ; 
                __context__.SourceCodeLine = 221;
                MakeString ( TO_DEVICE__DOLLAR__ , "DCCH{0}  \r", SCHANNELF ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 223;
                if ( Functions.TestForTrue  ( ( CABLE  .Value)  ) ) 
                    { 
                    __context__.SourceCodeLine = 225;
                    MakeString ( SCHANNELF , "{0:d3}", (short)Functions.Atoi( SNUMBER )) ; 
                    __context__.SourceCodeLine = 226;
                    MakeString ( TO_DEVICE__DOLLAR__ , "DCCH{0} \r", SCHANNELF ) ; 
                    } 
                
                }
            
            } 
        
        __context__.SourceCodeLine = 229;
        Functions.ClearBuffer ( SNUMBER ) ; 
        __context__.SourceCodeLine = 230;
        NUMBER__DOLLAR__  .UpdateValue ( SNUMBER  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 242;
        Functions.ClearBuffer ( SNUMBER ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SCHANNELF  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
    SCHANNELR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
    
    KP0 = new Crestron.Logos.SplusObjects.DigitalInput( KP0__DigitalInput__, this );
    m_DigitalInputList.Add( KP0__DigitalInput__, KP0 );
    
    KP1 = new Crestron.Logos.SplusObjects.DigitalInput( KP1__DigitalInput__, this );
    m_DigitalInputList.Add( KP1__DigitalInput__, KP1 );
    
    KP2 = new Crestron.Logos.SplusObjects.DigitalInput( KP2__DigitalInput__, this );
    m_DigitalInputList.Add( KP2__DigitalInput__, KP2 );
    
    KP3 = new Crestron.Logos.SplusObjects.DigitalInput( KP3__DigitalInput__, this );
    m_DigitalInputList.Add( KP3__DigitalInput__, KP3 );
    
    KP4 = new Crestron.Logos.SplusObjects.DigitalInput( KP4__DigitalInput__, this );
    m_DigitalInputList.Add( KP4__DigitalInput__, KP4 );
    
    KP5 = new Crestron.Logos.SplusObjects.DigitalInput( KP5__DigitalInput__, this );
    m_DigitalInputList.Add( KP5__DigitalInput__, KP5 );
    
    KP6 = new Crestron.Logos.SplusObjects.DigitalInput( KP6__DigitalInput__, this );
    m_DigitalInputList.Add( KP6__DigitalInput__, KP6 );
    
    KP7 = new Crestron.Logos.SplusObjects.DigitalInput( KP7__DigitalInput__, this );
    m_DigitalInputList.Add( KP7__DigitalInput__, KP7 );
    
    KP8 = new Crestron.Logos.SplusObjects.DigitalInput( KP8__DigitalInput__, this );
    m_DigitalInputList.Add( KP8__DigitalInput__, KP8 );
    
    KP9 = new Crestron.Logos.SplusObjects.DigitalInput( KP9__DigitalInput__, this );
    m_DigitalInputList.Add( KP9__DigitalInput__, KP9 );
    
    KP_DOT = new Crestron.Logos.SplusObjects.DigitalInput( KP_DOT__DigitalInput__, this );
    m_DigitalInputList.Add( KP_DOT__DigitalInput__, KP_DOT );
    
    KP_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( KP_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( KP_CLEAR__DigitalInput__, KP_CLEAR );
    
    KP_ENTER = new Crestron.Logos.SplusObjects.DigitalInput( KP_ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( KP_ENTER__DigitalInput__, KP_ENTER );
    
    AIR = new Crestron.Logos.SplusObjects.DigitalInput( AIR__DigitalInput__, this );
    m_DigitalInputList.Add( AIR__DigitalInput__, AIR );
    
    CABLE = new Crestron.Logos.SplusObjects.DigitalInput( CABLE__DigitalInput__, this );
    m_DigitalInputList.Add( CABLE__DigitalInput__, CABLE );
    
    NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NUMBER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NUMBER__DOLLAR____AnalogSerialOutput__, NUMBER__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    
    KP0.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP0_OnPush_0, false ) );
    KP1.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP1_OnPush_1, false ) );
    KP2.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP2_OnPush_2, false ) );
    KP3.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP3_OnPush_3, false ) );
    KP4.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP4_OnPush_4, false ) );
    KP5.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP5_OnPush_5, false ) );
    KP6.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP6_OnPush_6, false ) );
    KP7.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP7_OnPush_7, false ) );
    KP8.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP8_OnPush_8, false ) );
    KP9.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP9_OnPush_9, false ) );
    KP_DOT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP_DOT_OnPush_10, false ) );
    KP_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP_CLEAR_OnPush_11, false ) );
    KP_ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( KP_ENTER_OnPush_12, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_SHARP_LC_52D64U_PROCESSOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint KP0__DigitalInput__ = 0;
const uint KP1__DigitalInput__ = 1;
const uint KP2__DigitalInput__ = 2;
const uint KP3__DigitalInput__ = 3;
const uint KP4__DigitalInput__ = 4;
const uint KP5__DigitalInput__ = 5;
const uint KP6__DigitalInput__ = 6;
const uint KP7__DigitalInput__ = 7;
const uint KP8__DigitalInput__ = 8;
const uint KP9__DigitalInput__ = 9;
const uint KP_DOT__DigitalInput__ = 10;
const uint KP_CLEAR__DigitalInput__ = 11;
const uint KP_ENTER__DigitalInput__ = 12;
const uint AIR__DigitalInput__ = 13;
const uint CABLE__DigitalInput__ = 14;
const uint NUMBER__DOLLAR____AnalogSerialOutput__ = 0;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
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
