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

namespace UserModule_TIVO_PREMIERE_PROCESSOR_V1_2
{
    public class UserModuleClass_TIVO_PREMIERE_PROCESSOR_V1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput KEY_DASH;
        Crestron.Logos.SplusObjects.DigitalInput KEY_ENTER;
        Crestron.Logos.SplusObjects.DigitalInput KEY_BACK;
        Crestron.Logos.SplusObjects.DigitalInput KEY_CLEAR;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> KEY_NUM;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_CHANNEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort SEMAPHORE = 0;
        ushort A = 0;
        CrestronString CHANNEL__DOLLAR__;
        CrestronString CURRENTCHAN__DOLLAR__;
        CrestronString TEMP__DOLLAR__;
        object KEY_NUM_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort INDEX = 0;
                ushort I = 0;
                ushort ICHAR = 0;
                
                CrestronString TEMP__DOLLAR__;
                CrestronString TEMP2__DOLLAR__;
                TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
                TEMP2__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
                
                
                __context__.SourceCodeLine = 54;
                INDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 55;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CHANNEL__DOLLAR__ ) < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 57;
                    MakeString ( CHANNEL__DOLLAR__ , "{0}{1:d}", CHANNEL__DOLLAR__ , (short)(INDEX - 1)) ; 
                    __context__.SourceCodeLine = 58;
                    TEMP__DOLLAR__  .UpdateValue ( CHANNEL__DOLLAR__  ) ; 
                    __context__.SourceCodeLine = 59;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( TEMP__DOLLAR__ ); 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 61;
                        ICHAR = (ushort) ( Functions.GetC( TEMP__DOLLAR__ ) ) ; 
                        __context__.SourceCodeLine = 62;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICHAR == 32))  ) ) 
                            {
                            __context__.SourceCodeLine = 63;
                            ICHAR = (ushort) ( 45 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 64;
                        TEMP2__DOLLAR__  .UpdateValue ( TEMP2__DOLLAR__ + Functions.Chr (  (int) ( ICHAR ) )  ) ; 
                        __context__.SourceCodeLine = 59;
                        } 
                    
                    __context__.SourceCodeLine = 66;
                    DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( TEMP2__DOLLAR__  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object KEY_DASH_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 72;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CHANNEL__DOLLAR__ ) < 10 ))  ) ) 
                { 
                __context__.SourceCodeLine = 74;
                MakeString ( CHANNEL__DOLLAR__ , "{0}\u0020", CHANNEL__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 75;
                MakeString ( DISPLAY_CHANNEL__DOLLAR__ , "{0}-", Functions.Mid ( CHANNEL__DOLLAR__ ,  (int) ( 1 ) ,  (int) ( (Functions.Length( CHANNEL__DOLLAR__ ) - 1) ) ) ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KEY_BACK_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort LENGTH = 0;
        
        
        __context__.SourceCodeLine = 82;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( CHANNEL__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 84;
            Functions.ClearBuffer ( TEMP__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 85;
            LENGTH = (ushort) ( Functions.Length( CHANNEL__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 86;
            CHANNEL__DOLLAR__  .UpdateValue ( Functions.Mid ( CHANNEL__DOLLAR__ ,  (int) ( 1 ) ,  (int) ( (LENGTH - 1) ) )  ) ; 
            __context__.SourceCodeLine = 87;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( CHANNEL__DOLLAR__ ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 89;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( CHANNEL__DOLLAR__ , (int)( A ) ) == 32))  ) ) 
                    {
                    __context__.SourceCodeLine = 90;
                    MakeString ( TEMP__DOLLAR__ , "{0}-", TEMP__DOLLAR__ ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 92;
                    MakeString ( TEMP__DOLLAR__ , "{0}{1}", TEMP__DOLLAR__ , Functions.Chr (  (int) ( Byte( CHANNEL__DOLLAR__ , (int)( A ) ) ) ) ) ; 
                    }
                
                __context__.SourceCodeLine = 87;
                } 
            
            __context__.SourceCodeLine = 94;
            DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( TEMP__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_CLEAR_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 100;
        CHANNEL__DOLLAR__  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 101;
        DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_ENTER_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 106;
        DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( "Changing Channels"  ) ; 
        __context__.SourceCodeLine = 107;
        Functions.Delay (  (int) ( 50 ) ) ; 
        __context__.SourceCodeLine = 108;
        MakeString ( TO_DEVICE__DOLLAR__ , "SETCH {0}\u000D", CHANNEL__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 109;
        CHANNEL__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort I = 0;
        ushort MARKER1 = 0;
        ushort MARKER2 = 0;
        ushort MARKER3 = 0;
        
        CrestronString TEMP__DOLLAR__;
        CrestronString TEMPCHAN__DOLLAR__;
        CrestronString TEMPSUBCHAN__DOLLAR__;
        CrestronString NEWCHAN__DOLLAR__;
        TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        TEMPCHAN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        TEMPSUBCHAN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        NEWCHAN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
        
        
        __context__.SourceCodeLine = 117;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 119;
            SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 120;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROM_DEVICE__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 122;
                TEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROM_DEVICE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 123;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "CH_STATUS" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 125;
                    MARKER1 = (ushort) ( Functions.Find( "\u0020" , TEMP__DOLLAR__ , 1 ) ) ; 
                    __context__.SourceCodeLine = 126;
                    MARKER2 = (ushort) ( Functions.Find( "\u0020" , TEMP__DOLLAR__ , (MARKER1 + 1) ) ) ; 
                    __context__.SourceCodeLine = 127;
                    MARKER3 = (ushort) ( Functions.Find( "\u0020" , TEMP__DOLLAR__ , (MARKER2 + 1) ) ) ; 
                    __context__.SourceCodeLine = 128;
                    TEMPCHAN__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( Functions.Atoi( Functions.Mid( TEMP__DOLLAR__ , (int)( (MARKER1 + 1) ) , (int)( (MARKER2 - (MARKER1 + 1)) ) ) ) ) )  ) ; 
                    __context__.SourceCodeLine = 129;
                    if ( Functions.TestForTrue  ( ( MARKER3)  ) ) 
                        {
                        __context__.SourceCodeLine = 130;
                        TEMPSUBCHAN__DOLLAR__  .UpdateValue ( Functions.ItoA (  (int) ( Functions.Atoi( Functions.Mid( TEMP__DOLLAR__ , (int)( (MARKER2 + 1) ) , (int)( (MARKER3 - (MARKER2 + 1)) ) ) ) ) )  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 131;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TEMPCHAN__DOLLAR__ ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 133;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( TEMPSUBCHAN__DOLLAR__ ) > 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 134;
                            MakeString ( NEWCHAN__DOLLAR__ , "{0}-{1}", TEMPCHAN__DOLLAR__ , TEMPSUBCHAN__DOLLAR__ ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 136;
                            MakeString ( NEWCHAN__DOLLAR__ , "{0}", TEMPCHAN__DOLLAR__ ) ; 
                            }
                        
                        __context__.SourceCodeLine = 137;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEWCHAN__DOLLAR__ != CURRENTCHAN__DOLLAR__))  ) ) 
                            { 
                            __context__.SourceCodeLine = 139;
                            CURRENTCHAN__DOLLAR__  .UpdateValue ( NEWCHAN__DOLLAR__  ) ; 
                            __context__.SourceCodeLine = 140;
                            DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( CURRENTCHAN__DOLLAR__  ) ; 
                            } 
                        
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 144;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "CH_FAILED" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 146;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "INVALID" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 148;
                            DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( "Invalid Channel"  ) ; 
                            __context__.SourceCodeLine = 149;
                            Functions.Delay (  (int) ( 300 ) ) ; 
                            __context__.SourceCodeLine = 150;
                            DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( CURRENTCHAN__DOLLAR__  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 152;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NO_LIVE" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 154;
                                DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( "Not Live"  ) ; 
                                __context__.SourceCodeLine = 155;
                                Functions.Delay (  (int) ( 300 ) ) ; 
                                __context__.SourceCodeLine = 156;
                                DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( CURRENTCHAN__DOLLAR__  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 158;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "RECORDING" , TEMP__DOLLAR__ ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 160;
                                    DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( "Recording Channel"  ) ; 
                                    __context__.SourceCodeLine = 161;
                                    Functions.Delay (  (int) ( 300 ) ) ; 
                                    __context__.SourceCodeLine = 162;
                                    DISPLAY_CHANNEL__DOLLAR__  .UpdateValue ( CURRENTCHAN__DOLLAR__  ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        } 
                    
                    }
                
                __context__.SourceCodeLine = 120;
                } 
            
            __context__.SourceCodeLine = 166;
            SEMAPHORE = (ushort) ( 0 ) ; 
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
        
        __context__.SourceCodeLine = 172;
        SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 173;
        CHANNEL__DOLLAR__  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    CHANNEL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    CURRENTCHAN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    TEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    KEY_DASH = new Crestron.Logos.SplusObjects.DigitalInput( KEY_DASH__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_DASH__DigitalInput__, KEY_DASH );
    
    KEY_ENTER = new Crestron.Logos.SplusObjects.DigitalInput( KEY_ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_ENTER__DigitalInput__, KEY_ENTER );
    
    KEY_BACK = new Crestron.Logos.SplusObjects.DigitalInput( KEY_BACK__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_BACK__DigitalInput__, KEY_BACK );
    
    KEY_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( KEY_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_CLEAR__DigitalInput__, KEY_CLEAR );
    
    KEY_NUM = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        KEY_NUM[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( KEY_NUM__DigitalInput__ + i, KEY_NUM__DigitalInput__, this );
        m_DigitalInputList.Add( KEY_NUM__DigitalInput__ + i, KEY_NUM[i+1] );
    }
    
    DISPLAY_CHANNEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_CHANNEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_CHANNEL__DOLLAR____AnalogSerialOutput__, DISPLAY_CHANNEL__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    
    for( uint i = 0; i < 10; i++ )
        KEY_NUM[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_NUM_OnPush_0, false ) );
        
    KEY_DASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_DASH_OnPush_1, false ) );
    KEY_BACK.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_BACK_OnPush_2, false ) );
    KEY_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_CLEAR_OnPush_3, false ) );
    KEY_ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_ENTER_OnPush_4, false ) );
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TIVO_PREMIERE_PROCESSOR_V1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint KEY_DASH__DigitalInput__ = 0;
const uint KEY_ENTER__DigitalInput__ = 1;
const uint KEY_BACK__DigitalInput__ = 2;
const uint KEY_CLEAR__DigitalInput__ = 3;
const uint KEY_NUM__DigitalInput__ = 4;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 0;
const uint DISPLAY_CHANNEL__DOLLAR____AnalogSerialOutput__ = 0;
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
