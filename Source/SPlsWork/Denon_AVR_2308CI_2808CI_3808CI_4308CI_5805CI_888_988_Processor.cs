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

namespace UserModule_DENON_AVR_2308CI_2808CI_3808CI_4308CI_5805CI_888_988_PROCESSOR
{
    public class UserModuleClass_DENON_AVR_2308CI_2808CI_3808CI_4308CI_5805CI_888_988_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput AM_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput FM_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput AM_HD_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput FM_HD_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput SENDMAIN;
        Crestron.Logos.SplusObjects.DigitalInput SENDZONE2;
        Crestron.Logos.SplusObjects.DigitalInput SENDZONE3;
        Crestron.Logos.SplusObjects.DigitalInput IPOD;
        Crestron.Logos.SplusObjects.DigitalInput USB;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_AM_FM;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_HD;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_XM;
        Crestron.Logos.SplusObjects.DigitalInput ENTER_DAB;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_AM_FM__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_HD__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_XM__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput DIRECT_KEY_DAB__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput FROMDEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput MAINLEVEL;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE2LEVEL;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE3LEVEL;
        Crestron.Logos.SplusObjects.StringOutput MAINLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ZONE2LEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ZONE3LEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SWLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SBLLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SBRLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SBLEVEL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput ANALOG_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_STATION_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_STATION_NAME_LONG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_SIGNAL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_MULTICAST_CURRENT_CH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_MULTICAST_CH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_PROGRAM_TYPE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_ALBUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_GENRE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_PRESET__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_RADIO_ID__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput XM_SIGNAL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_STATION_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_STATION_NAME_LONG__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_ENSEMBLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_PROGRAM_TYPE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_CHANNEL_CH__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_MODE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_SIGNAL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DAB_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_0__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput IPOD_LINE_8__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_0__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_1__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_2__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_3__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_4__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_5__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_6__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_7__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USB_NSA_LINE_8__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DIRECT_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput MUTE_MAIN__DOLLAR__;
        ushort LEVEL = 0;
        ushort SEMAPHORE = 0;
        ushort FL = 0;
        ushort FR = 0;
        ushort SL = 0;
        ushort SR = 0;
        ushort SBL = 0;
        ushort SBR = 0;
        ushort C = 0;
        ushort SW = 0;
        ushort SB = 0;
        ushort FREQHI = 0;
        ushort FREQLO = 0;
        CrestronString TEMPSTRING__DOLLAR__;
        CrestronString COMMAND__DOLLAR__;
        CrestronString SUB__DOLLAR__;
        CrestronString SUB3__DOLLAR__;
        CrestronString MAINLEVELINT__DOLLAR__;
        CrestronString ZONE2LEVELINT__DOLLAR__;
        CrestronString MAINLEVELSENT__DOLLAR__;
        CrestronString ZONE2LEVELSENT__DOLLAR__;
        CrestronString ZONE3LEVELINT__DOLLAR__;
        CrestronString ZONE3LEVELSENT__DOLLAR__;
        CrestronString ZONE4LEVELINT__DOLLAR__;
        private CrestronString CALCULATEVOLUMETEXT (  SplusExecutionContext __context__, ushort VALUE ) 
            { 
            CrestronString TEXT__DOLLAR__;
            TEXT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString VALUE__DOLLAR__;
            VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            ushort REMAINDER = 0;
            
            
            __context__.SourceCodeLine = 96;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( VALUE >= 800 ))  ) ) 
                {
                __context__.SourceCodeLine = 97;
                MakeString ( TEXT__DOLLAR__ , "{0:d}.{1:d} dB", (ushort)((VALUE - 800) / 10), (ushort)Mod( (VALUE - 800) , 10 )) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 100;
                VALUE = (ushort) ( Functions.ToInteger( -( (VALUE - 800) ) ) ) ; 
                __context__.SourceCodeLine = 101;
                MakeString ( VALUE__DOLLAR__ , "{0:d3}\r\n", (ushort)VALUE) ; 
                __context__.SourceCodeLine = 102;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Mod( VALUE , 10 ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 103;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.5 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 105;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.0 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 107;
            return ( TEXT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString CALCULATECHANNELTEXT (  SplusExecutionContext __context__, ushort VALUE ) 
            { 
            CrestronString TEXT__DOLLAR__;
            TEXT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            CrestronString VALUE__DOLLAR__;
            VALUE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
            
            ushort REMAINDER = 0;
            
            
            __context__.SourceCodeLine = 116;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( VALUE >= 500 ))  ) ) 
                {
                __context__.SourceCodeLine = 117;
                MakeString ( TEXT__DOLLAR__ , "{0:d}.{1:d} dB", (ushort)((VALUE - 500) / 10), (ushort)Mod( (VALUE - 500) , 10 )) ; 
                }
            
            else 
                { 
                __context__.SourceCodeLine = 120;
                VALUE = (ushort) ( Functions.ToInteger( -( (VALUE - 500) ) ) ) ; 
                __context__.SourceCodeLine = 121;
                MakeString ( VALUE__DOLLAR__ , "{0:d3}\r\n", (ushort)VALUE) ; 
                __context__.SourceCodeLine = 122;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Mod( VALUE , 10 ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 123;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.5 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 125;
                    MakeString ( TEXT__DOLLAR__ , "- {0:d}.0 dB", (ushort)(VALUE / 10)) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 127;
            return ( TEXT__DOLLAR__ ) ; 
            
            }
            
        private CrestronString REMOVENULLS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString STEMP__DOLLAR__;
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            ushort INULLLOCATION = 0;
            ushort ILENGTH = 0;
            
            
            __context__.SourceCodeLine = 135;
            STEMP__DOLLAR__  .UpdateValue ( TEMPSTRING__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 136;
            INULLLOCATION = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 137;
            while ( Functions.TestForTrue  ( ( Functions.Find( "\u0000" , STEMP__DOLLAR__ ))  ) ) 
                { 
                __context__.SourceCodeLine = 140;
                STEMP__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u0000" , TEMPSTRING__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 141;
                INULLLOCATION = (ushort) ( Functions.Find( "\u0000" , STEMP__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 142;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INULLLOCATION > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 142;
                    ILENGTH = (ushort) ( SetString( "\u0020" , (int)INULLLOCATION , STEMP__DOLLAR__ ) ) ; 
                    }
                
                __context__.SourceCodeLine = 137;
                } 
            
            __context__.SourceCodeLine = 144;
            return ( STEMP__DOLLAR__ ) ; 
            
            }
            
        object DIRECT_KEY_AM_FM__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort ILENGTH = 0;
                
                CrestronString STEMP__DOLLAR__;
                STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
                
                
                __context__.SourceCodeLine = 176;
                ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 177;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 177;
                    STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_AM_FM__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 178;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_AM_FM__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 180;
                    Functions.ClearBuffer ( DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
                    } 
                
                __context__.SourceCodeLine = 185;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 7))  ) ) 
                    { 
                    __context__.SourceCodeLine = 187;
                    DIRECT_KEY_AM_FM__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
                    } 
                
                __context__.SourceCodeLine = 190;
                DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__  .UpdateValue ( DIRECT_KEY_AM_FM__DOLLAR__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DIRECT_KEY_HD__DOLLAR___OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort ILENGTH = 0;
            
            CrestronString STEMP__DOLLAR__;
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
            
            
            __context__.SourceCodeLine = 218;
            ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 219;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 219;
                STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_HD__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 220;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_HD__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 222;
                Functions.ClearBuffer ( DIRECT_KEY_HD__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 227;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 7))  ) ) 
                { 
                __context__.SourceCodeLine = 229;
                DIRECT_KEY_HD__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
                } 
            
            __context__.SourceCodeLine = 232;
            DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__  .UpdateValue ( DIRECT_KEY_HD__DOLLAR__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object DIRECT_KEY_XM__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ILENGTH = 0;
        
        CrestronString STEMP__DOLLAR__;
        STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
        
        
        __context__.SourceCodeLine = 243;
        ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 244;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 244;
            STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_XM__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 245;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_XM__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 247;
            Functions.ClearBuffer ( DIRECT_KEY_XM__DOLLAR__ ) ; 
            } 
        
        __context__.SourceCodeLine = 250;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 4))  ) ) 
            { 
            __context__.SourceCodeLine = 252;
            DIRECT_KEY_XM__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
            } 
        
        __context__.SourceCodeLine = 254;
        DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__  .UpdateValue ( DIRECT_KEY_XM__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECT_KEY_DAB__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ILENGTH = 0;
        
        CrestronString STEMP__DOLLAR__;
        STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
        
        
        __context__.SourceCodeLine = 264;
        ILENGTH = (ushort) ( Functions.Length( DIRECT_KEY_DAB__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 265;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ILENGTH > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 265;
            STEMP__DOLLAR__  .UpdateValue ( Functions.Right ( DIRECT_KEY_DAB__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 266;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u0000" , DIRECT_KEY_DAB__DOLLAR__ ) > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 268;
            Functions.ClearBuffer ( DIRECT_KEY_DAB__DOLLAR__ ) ; 
            } 
        
        __context__.SourceCodeLine = 270;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ILENGTH == 7))  ) ) 
            { 
            __context__.SourceCodeLine = 272;
            DIRECT_KEY_DAB__DOLLAR__  .UpdateValue ( STEMP__DOLLAR__  ) ; 
            } 
        
        __context__.SourceCodeLine = 274;
        DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__  .UpdateValue ( DIRECT_KEY_DAB__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROMDEVICE__DOLLAR___OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort ISTRINGLENGTH = 0;
        
        
        __context__.SourceCodeLine = 285;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 287;
            SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 288;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROMDEVICE__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 290;
                TEMPSTRING__DOLLAR__  .UpdateValue ( ""  ) ; 
                __context__.SourceCodeLine = 291;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "MUON" , FROMDEVICE__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "Z2MUON" , FROMDEVICE__DOLLAR__ ) == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "Z3MUON" , FROMDEVICE__DOLLAR__ ) == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 293;
                    MUTE_MAIN__DOLLAR__  .UpdateValue ( "Z1MUON"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 295;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "MUOFF" , FROMDEVICE__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "Z2MUOFF" , FROMDEVICE__DOLLAR__ ) == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "Z3MUOFF" , FROMDEVICE__DOLLAR__ ) == 0) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 297;
                    MUTE_MAIN__DOLLAR__  .UpdateValue ( "Z1MUOFF"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 299;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "MVMAX" , FROMDEVICE__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 301;
                    TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "MVMAX" , FROMDEVICE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 302;
                    TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , TEMPSTRING__DOLLAR__ )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 305;
                    TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROMDEVICE__DOLLAR__ )  ) ; 
                    }
                
                __context__.SourceCodeLine = 307;
                COMMAND__DOLLAR__  .UpdateValue ( Functions.Left ( TEMPSTRING__DOLLAR__ ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 308;
                ISTRINGLENGTH = (ushort) ( Functions.Find( "\u000D" , TEMPSTRING__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 310;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDST NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 310;
                    HD_STATION_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 311;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDSTL NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 311;
                    HD_STATION_NAME_LONG__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 11 ) ,  (int) ( (ISTRINGLENGTH - 11) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 312;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDSIG" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 312;
                    HD_SIGNAL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 313;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDMLT CURRENT" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 313;
                    HD_MULTICAST_CURRENT_CH__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 14 ) ,  (int) ( (ISTRINGLENGTH - 14) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 314;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDMLT CAST CH" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 314;
                    HD_MULTICAST_CH__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 14 ) ,  (int) ( (ISTRINGLENGTH - 14) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 315;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HDPTY" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 315;
                    HD_PROGRAM_TYPE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 316;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HD ARTIST" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 316;
                    HD_ARTIST__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 317;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HD TITLE" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 317;
                    HD_TITLE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 318;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HD ALBUM" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 318;
                    HD_ALBUM__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 319;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "HD GENRE" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 319;
                    HD_GENRE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 322;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "TPXMA" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 322;
                    XM_PRESET__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 323;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMCH NAME " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 323;
                    XM_CHANNEL_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 11 ) ,  (int) ( (ISTRINGLENGTH - 11) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 324;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMARTIST " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 324;
                    XM_ARTIST__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 325;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMTITLE " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 325;
                    XM_TITLE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 326;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMXMID " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 326;
                    XM_RADIO_ID__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 327;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "XMSIGNAL " , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 327;
                    XM_SIGNAL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 9 ) ,  (int) ( (ISTRINGLENGTH - 9) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 330;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABST NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 330;
                    DAB_STATION_NAME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 331;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABSTL NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 331;
                    DAB_STATION_NAME_LONG__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 11 ) ,  (int) ( (ISTRINGLENGTH - 11) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 332;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABEN NAME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 332;
                    DAB_ENSEMBLE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 10 ) ,  (int) ( (ISTRINGLENGTH - 10) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 333;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABPTY" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 333;
                    DAB_PROGRAM_TYPE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (ISTRINGLENGTH - 7) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 334;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "DAB" , TEMPSTRING__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMPSTRING__DOLLAR__ ) == 7) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 334;
                    DAB_CHANNEL_CH__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( (ISTRINGLENGTH - 4) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 335;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "DAB" , TEMPSTRING__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMPSTRING__DOLLAR__ ) == 10) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 335;
                    DAB_FREQUENCY__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 4 ) ,  (int) ( (ISTRINGLENGTH - 4) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 336;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABMODE" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 336;
                    DAB_MODE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 337;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABSIG" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 337;
                    DAB_SIGNAL__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 7 ) ,  (int) ( (ISTRINGLENGTH - 7) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 339;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABTIME" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 339;
                    DAB_TIME__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 340;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "DABDATE" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 340;
                    DAB_DATE__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 8 ) ,  (int) ( (ISTRINGLENGTH - 8) ) )  ) ; 
                    }
                
                __context__.SourceCodeLine = 347;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA0" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 349;
                    IPOD_LINE_0__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 351;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA1" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 353;
                    IPOD_LINE_1__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 355;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA2" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 357;
                    IPOD_LINE_2__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 359;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA3" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 361;
                    IPOD_LINE_3__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 363;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA4" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 365;
                    IPOD_LINE_4__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 367;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA5" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 369;
                    IPOD_LINE_5__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 371;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA6" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 373;
                    IPOD_LINE_6__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 375;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA7" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 377;
                    IPOD_LINE_7__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 379;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "IPA8" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 381;
                    IPOD_LINE_8__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 386;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA0" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 389;
                    USB_NSA_LINE_0__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 391;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA1" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 393;
                    USB_NSA_LINE_1__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 395;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA2" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 397;
                    USB_NSA_LINE_2__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 399;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA3" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 401;
                    USB_NSA_LINE_3__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 403;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA4" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 405;
                    USB_NSA_LINE_4__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 407;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA5" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 409;
                    USB_NSA_LINE_5__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 411;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA6" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 413;
                    USB_NSA_LINE_6__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 6 ) ,  (int) ( (ISTRINGLENGTH - 6) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 415;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA7" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 417;
                    USB_NSA_LINE_7__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 419;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NSA8" , TEMPSTRING__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 421;
                    USB_NSA_LINE_8__DOLLAR__  .UpdateValue ( Functions.Mid ( REMOVENULLS (  __context__  ) ,  (int) ( 5 ) ,  (int) ( (ISTRINGLENGTH - 5) ) )  ) ; 
                    } 
                
                __context__.SourceCodeLine = 426;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMAND__DOLLAR__ == "MV"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 428;
                    LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) ) * 2) ) ; 
                    __context__.SourceCodeLine = 429;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVEL == 198))  ) ) 
                        { 
                        __context__.SourceCodeLine = 431;
                        MAINLEVEL  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 432;
                        MAINLEVELINT__DOLLAR__  .UpdateValue ( "---"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 436;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53))  ) ) 
                            {
                            __context__.SourceCodeLine = 437;
                            LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                            }
                        
                        __context__.SourceCodeLine = 438;
                        MAINLEVEL  .Value = (ushort) ( LEVEL ) ; 
                        __context__.SourceCodeLine = 439;
                        LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                        __context__.SourceCodeLine = 440;
                        MAINLEVELINT__DOLLAR__  .UpdateValue ( CALCULATEVOLUMETEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                        } 
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 443;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND__DOLLAR__ == "Z2") ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) >= 48 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) <= 57 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 445;
                        LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) ) * 2) ) ; 
                        __context__.SourceCodeLine = 446;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVEL == 198))  ) ) 
                            { 
                            __context__.SourceCodeLine = 448;
                            ZONE2LEVEL  .Value = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 449;
                            ZONE2LEVELINT__DOLLAR__  .UpdateValue ( "---"  ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 453;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53))  ) ) 
                                {
                                __context__.SourceCodeLine = 454;
                                LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                }
                            
                            __context__.SourceCodeLine = 455;
                            ZONE2LEVEL  .Value = (ushort) ( LEVEL ) ; 
                            __context__.SourceCodeLine = 456;
                            LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                            __context__.SourceCodeLine = 457;
                            ZONE2LEVELINT__DOLLAR__  .UpdateValue ( CALCULATEVOLUMETEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 460;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND__DOLLAR__ == "Z3") ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) >= 48 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) <= 57 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 462;
                            LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 3 ) , (int)( 2 ) ) ) * 2) ) ; 
                            __context__.SourceCodeLine = 463;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LEVEL == 198))  ) ) 
                                { 
                                __context__.SourceCodeLine = 465;
                                ZONE3LEVEL  .Value = (ushort) ( 0 ) ; 
                                __context__.SourceCodeLine = 466;
                                ZONE3LEVELINT__DOLLAR__  .UpdateValue ( "---"  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 470;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 5 ) ) == 53))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 471;
                                    LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 472;
                                ZONE3LEVEL  .Value = (ushort) ( LEVEL ) ; 
                                __context__.SourceCodeLine = 473;
                                LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                __context__.SourceCodeLine = 474;
                                ZONE3LEVELINT__DOLLAR__  .UpdateValue ( CALCULATEVOLUMETEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 477;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFAN") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "CMP" , TEMPSTRING__DOLLAR__ ) == 0) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 479;
                                FREQHI = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 4 ) ) ) ) ; 
                                __context__.SourceCodeLine = 480;
                                FREQLO = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 9 ) , (int)( 2 ) ) ) ) ; 
                                __context__.SourceCodeLine = 481;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( TEMPSTRING__DOLLAR__ ) > 50000 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 483;
                                    MakeString ( ANALOG_TUNER_FREQUENCY__DOLLAR__ , "{0:d} kHz", (ushort)FREQHI) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 487;
                                    MakeString ( ANALOG_TUNER_FREQUENCY__DOLLAR__ , "{0:d}.{1:d} MHz", (ushort)FREQHI, (ushort)FREQLO) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 491;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFXM") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "CMP" , TEMPSTRING__DOLLAR__ ) == 0) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 493;
                                    MakeString ( XM_TUNER_FREQUENCY__DOLLAR__ , "XM-{0:d}", (ushort)Functions.Atoi( TEMPSTRING__DOLLAR__ )) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 496;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFDA") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "CMP" , TEMPSTRING__DOLLAR__ ) == 0) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 498;
                                        MakeString ( DAB_TUNER_FREQUENCY__DOLLAR__ , "XM-{0:d}", (ushort)Functions.Atoi( TEMPSTRING__DOLLAR__ )) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 501;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) == "TFHD") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( TEMPSTRING__DOLLAR__ ) == 11) )) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 503;
                                            FREQHI = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 4 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 504;
                                            FREQLO = (ushort) ( Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 9 ) , (int)( 2 ) ) ) ) ; 
                                            __context__.SourceCodeLine = 505;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( TEMPSTRING__DOLLAR__ ) > 50000 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 507;
                                                MakeString ( HD_TUNER_FREQUENCY__DOLLAR__ , "{0:d} kHz", (ushort)FREQHI) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 511;
                                                MakeString ( HD_TUNER_FREQUENCY__DOLLAR__ , "{0:d}.{1:d} MHz", (ushort)FREQHI, (ushort)FREQLO) ; 
                                                } 
                                            
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 515;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMAND__DOLLAR__ == "CV"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 517;
                                                SUB__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 3 ) )  ) ; 
                                                __context__.SourceCodeLine = 518;
                                                SUB3__DOLLAR__  .UpdateValue ( Functions.Mid ( TEMPSTRING__DOLLAR__ ,  (int) ( 3 ) ,  (int) ( 1 ) )  ) ; 
                                                __context__.SourceCodeLine = 519;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBL") ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBR") )) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 521;
                                                    LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 7 ) , (int)( 2 ) ) ) * 2) ) ; 
                                                    __context__.SourceCodeLine = 522;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 9 ) ) == 53))  ) ) 
                                                        {
                                                        __context__.SourceCodeLine = 523;
                                                        LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                                        }
                                                    
                                                    __context__.SourceCodeLine = 524;
                                                    LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                                    __context__.SourceCodeLine = 525;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBL") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SBL) )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 527;
                                                        SBLLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                        __context__.SourceCodeLine = 528;
                                                        SBL = (ushort) ( LEVEL ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 530;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SBR") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SBR) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 532;
                                                            SBRLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                            __context__.SourceCodeLine = 533;
                                                            SBR = (ushort) ( LEVEL ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 536;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SB ") ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SR ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SL ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SW ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FL ") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FR ") )) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 538;
                                                        LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 6 ) , (int)( 2 ) ) ) * 2) ) ; 
                                                        __context__.SourceCodeLine = 539;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 8 ) ) == 53))  ) ) 
                                                            {
                                                            __context__.SourceCodeLine = 540;
                                                            LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                                            }
                                                        
                                                        __context__.SourceCodeLine = 541;
                                                        LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                                        __context__.SourceCodeLine = 542;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SB ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SB) )) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 544;
                                                            SBLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                            __context__.SourceCodeLine = 545;
                                                            SB = (ushort) ( LEVEL ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 547;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SR ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SR) )) ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 549;
                                                                SRLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                __context__.SourceCodeLine = 550;
                                                                SR = (ushort) ( LEVEL ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 552;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SL ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SL) )) ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 554;
                                                                    SLLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                    __context__.SourceCodeLine = 555;
                                                                    SL = (ushort) ( LEVEL ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 557;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "SW ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != SW) )) ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 559;
                                                                        SWLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                        __context__.SourceCodeLine = 560;
                                                                        SW = (ushort) ( LEVEL ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 562;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FR ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != FR) )) ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 564;
                                                                            FRLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                            __context__.SourceCodeLine = 565;
                                                                            FR = (ushort) ( LEVEL ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 567;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SUB__DOLLAR__ == "FL ") ) && Functions.TestForTrue ( Functions.BoolToInt (LEVEL != FL) )) ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 569;
                                                                                FLLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                                __context__.SourceCodeLine = 570;
                                                                                FL = (ushort) ( LEVEL ) ; 
                                                                                } 
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 573;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SUB3__DOLLAR__ == "C"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 575;
                                                            LEVEL = (ushort) ( (Functions.Atoi( Functions.Mid( TEMPSTRING__DOLLAR__ , (int)( 5 ) , (int)( 2 ) ) ) * 2) ) ; 
                                                            __context__.SourceCodeLine = 576;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( TEMPSTRING__DOLLAR__ , (int)( 7 ) ) == 53))  ) ) 
                                                                {
                                                                __context__.SourceCodeLine = 577;
                                                                LEVEL = (ushort) ( (LEVEL + 1) ) ; 
                                                                }
                                                            
                                                            __context__.SourceCodeLine = 578;
                                                            LEVEL = (ushort) ( (LEVEL * 5) ) ; 
                                                            __context__.SourceCodeLine = 579;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (C != LEVEL))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 581;
                                                                CLEVEL__DOLLAR__  .UpdateValue ( CALCULATECHANNELTEXT (  __context__ , (ushort)( LEVEL ))  ) ; 
                                                                __context__.SourceCodeLine = 582;
                                                                C = (ushort) ( LEVEL ) ; 
                                                                } 
                                                            
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 288;
                } 
            
            __context__.SourceCodeLine = 587;
            SEMAPHORE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENDMAIN_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 593;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAINLEVELSENT__DOLLAR__ != MAINLEVELINT__DOLLAR__))  ) ) 
            { 
            __context__.SourceCodeLine = 595;
            MAINLEVEL__DOLLAR__  .UpdateValue ( MAINLEVELINT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 596;
            MAINLEVELSENT__DOLLAR__  .UpdateValue ( MAINLEVELINT__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENDZONE2_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 602;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ZONE2LEVELSENT__DOLLAR__ != ZONE2LEVELINT__DOLLAR__))  ) ) 
            { 
            __context__.SourceCodeLine = 604;
            ZONE2LEVEL__DOLLAR__  .UpdateValue ( ZONE2LEVELINT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 605;
            ZONE2LEVELSENT__DOLLAR__  .UpdateValue ( ZONE2LEVELINT__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENDZONE3_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 611;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ZONE3LEVELSENT__DOLLAR__ != ZONE3LEVELINT__DOLLAR__))  ) ) 
            { 
            __context__.SourceCodeLine = 613;
            ZONE3LEVEL__DOLLAR__  .UpdateValue ( ZONE3LEVELINT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 614;
            ZONE3LEVELSENT__DOLLAR__  .UpdateValue ( ZONE3LEVELINT__DOLLAR__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_AM_FM_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 641;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 641;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN0{0}00\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 642;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 642;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}00\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 643;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 643;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}0\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 644;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 644;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 646;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 646;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN00{0}0\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 647;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 647;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN00{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 648;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 648;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN0{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 649;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_AM_FM__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 649;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFAN{0}\r", DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 650;
        Functions.ClearBuffer ( DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_HD_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 655;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 655;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD0{0}00\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 656;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 656;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}00\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 657;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 657;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}0\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 658;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( AM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 658;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 660;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 3) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 660;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD00{0}0\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 661;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 4) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 661;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD00{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 662;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 5) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 662;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD0{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 663;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FM_HD_ENABLED  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_HD__DOLLAR__ ) == 6) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 663;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFHD{0}\r", DIRECT_KEY_HD__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 664;
        Functions.ClearBuffer ( DIRECT_KEY_HD__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_XM_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 670;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) == 3))  ) ) 
            {
            __context__.SourceCodeLine = 670;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFXM{0}\r", DIRECT_KEY_XM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 671;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) == 2))  ) ) 
            {
            __context__.SourceCodeLine = 671;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFXM0{0}\r", DIRECT_KEY_XM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 672;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_XM__DOLLAR__ ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 672;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFXM00{0}\r", DIRECT_KEY_XM__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 673;
        Functions.ClearBuffer ( DIRECT_KEY_XM__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_DAB_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 679;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( DIRECT_KEY_DAB__DOLLAR__ ) == 6))  ) ) 
            {
            __context__.SourceCodeLine = 679;
            MakeString ( DIRECT_COMMAND__DOLLAR__ , "TFDA{0}\r", DIRECT_KEY_DAB__DOLLAR__ ) ; 
            }
        
        __context__.SourceCodeLine = 680;
        Functions.ClearBuffer ( DIRECT_KEY_DAB__DOLLAR__ ) ; 
        
        
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
        
        __context__.SourceCodeLine = 693;
        SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 694;
        FL = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 695;
        FR = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 696;
        SL = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 697;
        SR = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 698;
        SBL = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 699;
        SBR = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 700;
        C = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 701;
        SW = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 702;
        SB = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 703;
        Functions.ClearBuffer ( MAINLEVELSENT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 704;
        Functions.ClearBuffer ( ZONE2LEVELSENT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 705;
        Functions.ClearBuffer ( ZONE3LEVELSENT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 706;
        Functions.ClearBuffer ( MAINLEVELINT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 707;
        Functions.ClearBuffer ( ZONE2LEVELINT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 708;
        Functions.ClearBuffer ( ZONE3LEVELINT__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 709;
        Functions.ClearBuffer ( DIRECT_KEY_AM_FM__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 710;
        Functions.ClearBuffer ( DIRECT_KEY_XM__DOLLAR__ ) ; 
        __context__.SourceCodeLine = 711;
        Functions.ClearBuffer ( DIRECT_KEY_DAB__DOLLAR__ ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    COMMAND__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    SUB__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    SUB3__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    MAINLEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE2LEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    MAINLEVELSENT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE2LEVELSENT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE3LEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE3LEVELSENT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    ZONE4LEVELINT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    
    AM_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( AM_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( AM_ENABLED__DigitalInput__, AM_ENABLED );
    
    FM_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( FM_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( FM_ENABLED__DigitalInput__, FM_ENABLED );
    
    AM_HD_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( AM_HD_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( AM_HD_ENABLED__DigitalInput__, AM_HD_ENABLED );
    
    FM_HD_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( FM_HD_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( FM_HD_ENABLED__DigitalInput__, FM_HD_ENABLED );
    
    SENDMAIN = new Crestron.Logos.SplusObjects.DigitalInput( SENDMAIN__DigitalInput__, this );
    m_DigitalInputList.Add( SENDMAIN__DigitalInput__, SENDMAIN );
    
    SENDZONE2 = new Crestron.Logos.SplusObjects.DigitalInput( SENDZONE2__DigitalInput__, this );
    m_DigitalInputList.Add( SENDZONE2__DigitalInput__, SENDZONE2 );
    
    SENDZONE3 = new Crestron.Logos.SplusObjects.DigitalInput( SENDZONE3__DigitalInput__, this );
    m_DigitalInputList.Add( SENDZONE3__DigitalInput__, SENDZONE3 );
    
    IPOD = new Crestron.Logos.SplusObjects.DigitalInput( IPOD__DigitalInput__, this );
    m_DigitalInputList.Add( IPOD__DigitalInput__, IPOD );
    
    USB = new Crestron.Logos.SplusObjects.DigitalInput( USB__DigitalInput__, this );
    m_DigitalInputList.Add( USB__DigitalInput__, USB );
    
    ENTER_AM_FM = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_AM_FM__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_AM_FM__DigitalInput__, ENTER_AM_FM );
    
    ENTER_HD = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_HD__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_HD__DigitalInput__, ENTER_HD );
    
    ENTER_XM = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_XM__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_XM__DigitalInput__, ENTER_XM );
    
    ENTER_DAB = new Crestron.Logos.SplusObjects.DigitalInput( ENTER_DAB__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER_DAB__DigitalInput__, ENTER_DAB );
    
    MAINLEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( MAINLEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAINLEVEL__AnalogSerialOutput__, MAINLEVEL );
    
    ZONE2LEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE2LEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE2LEVEL__AnalogSerialOutput__, ZONE2LEVEL );
    
    ZONE3LEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE3LEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE3LEVEL__AnalogSerialOutput__, ZONE3LEVEL );
    
    MAINLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MAINLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAINLEVEL__DOLLAR____AnalogSerialOutput__, MAINLEVEL__DOLLAR__ );
    
    ZONE2LEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ZONE2LEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2LEVEL__DOLLAR____AnalogSerialOutput__, ZONE2LEVEL__DOLLAR__ );
    
    ZONE3LEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ZONE3LEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3LEVEL__DOLLAR____AnalogSerialOutput__, ZONE3LEVEL__DOLLAR__ );
    
    FLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FLLEVEL__DOLLAR____AnalogSerialOutput__, FLLEVEL__DOLLAR__ );
    
    FRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRLEVEL__DOLLAR____AnalogSerialOutput__, FRLEVEL__DOLLAR__ );
    
    CLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CLEVEL__DOLLAR____AnalogSerialOutput__, CLEVEL__DOLLAR__ );
    
    SWLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SWLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SWLEVEL__DOLLAR____AnalogSerialOutput__, SWLEVEL__DOLLAR__ );
    
    SLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SLLEVEL__DOLLAR____AnalogSerialOutput__, SLLEVEL__DOLLAR__ );
    
    SRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SRLEVEL__DOLLAR____AnalogSerialOutput__, SRLEVEL__DOLLAR__ );
    
    SBLLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SBLLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SBLLEVEL__DOLLAR____AnalogSerialOutput__, SBLLEVEL__DOLLAR__ );
    
    SBRLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SBRLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SBRLEVEL__DOLLAR____AnalogSerialOutput__, SBRLEVEL__DOLLAR__ );
    
    SBLEVEL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SBLEVEL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SBLEVEL__DOLLAR____AnalogSerialOutput__, SBLEVEL__DOLLAR__ );
    
    ANALOG_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ANALOG_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ANALOG_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, ANALOG_TUNER_FREQUENCY__DOLLAR__ );
    
    HD_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, HD_TUNER_FREQUENCY__DOLLAR__ );
    
    XM_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, XM_TUNER_FREQUENCY__DOLLAR__ );
    
    DAB_TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, DAB_TUNER_FREQUENCY__DOLLAR__ );
    
    HD_STATION_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_STATION_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_STATION_NAME__DOLLAR____AnalogSerialOutput__, HD_STATION_NAME__DOLLAR__ );
    
    HD_STATION_NAME_LONG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, HD_STATION_NAME_LONG__DOLLAR__ );
    
    HD_SIGNAL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_SIGNAL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_SIGNAL__DOLLAR____AnalogSerialOutput__, HD_SIGNAL__DOLLAR__ );
    
    HD_MULTICAST_CURRENT_CH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_MULTICAST_CURRENT_CH__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_MULTICAST_CURRENT_CH__DOLLAR____AnalogSerialOutput__, HD_MULTICAST_CURRENT_CH__DOLLAR__ );
    
    HD_MULTICAST_CH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_MULTICAST_CH__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_MULTICAST_CH__DOLLAR____AnalogSerialOutput__, HD_MULTICAST_CH__DOLLAR__ );
    
    HD_PROGRAM_TYPE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, HD_PROGRAM_TYPE__DOLLAR__ );
    
    HD_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_ARTIST__DOLLAR____AnalogSerialOutput__, HD_ARTIST__DOLLAR__ );
    
    HD_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TITLE__DOLLAR____AnalogSerialOutput__, HD_TITLE__DOLLAR__ );
    
    HD_ALBUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_ALBUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_ALBUM__DOLLAR____AnalogSerialOutput__, HD_ALBUM__DOLLAR__ );
    
    HD_GENRE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_GENRE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_GENRE__DOLLAR____AnalogSerialOutput__, HD_GENRE__DOLLAR__ );
    
    XM_PRESET__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_PRESET__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_PRESET__DOLLAR____AnalogSerialOutput__, XM_PRESET__DOLLAR__ );
    
    XM_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, XM_CHANNEL_NAME__DOLLAR__ );
    
    XM_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_ARTIST__DOLLAR____AnalogSerialOutput__, XM_ARTIST__DOLLAR__ );
    
    XM_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_TITLE__DOLLAR____AnalogSerialOutput__, XM_TITLE__DOLLAR__ );
    
    XM_RADIO_ID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_RADIO_ID__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_RADIO_ID__DOLLAR____AnalogSerialOutput__, XM_RADIO_ID__DOLLAR__ );
    
    XM_SIGNAL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( XM_SIGNAL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( XM_SIGNAL__DOLLAR____AnalogSerialOutput__, XM_SIGNAL__DOLLAR__ );
    
    DAB_STATION_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_STATION_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_STATION_NAME__DOLLAR____AnalogSerialOutput__, DAB_STATION_NAME__DOLLAR__ );
    
    DAB_STATION_NAME_LONG__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__, DAB_STATION_NAME_LONG__DOLLAR__ );
    
    DAB_ENSEMBLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_ENSEMBLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_ENSEMBLE__DOLLAR____AnalogSerialOutput__, DAB_ENSEMBLE__DOLLAR__ );
    
    DAB_PROGRAM_TYPE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__, DAB_PROGRAM_TYPE__DOLLAR__ );
    
    DAB_CHANNEL_CH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_CHANNEL_CH__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_CHANNEL_CH__DOLLAR____AnalogSerialOutput__, DAB_CHANNEL_CH__DOLLAR__ );
    
    DAB_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_FREQUENCY__DOLLAR____AnalogSerialOutput__, DAB_FREQUENCY__DOLLAR__ );
    
    DAB_MODE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_MODE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_MODE__DOLLAR____AnalogSerialOutput__, DAB_MODE__DOLLAR__ );
    
    DAB_SIGNAL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_SIGNAL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_SIGNAL__DOLLAR____AnalogSerialOutput__, DAB_SIGNAL__DOLLAR__ );
    
    DAB_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_TIME__DOLLAR____AnalogSerialOutput__, DAB_TIME__DOLLAR__ );
    
    DAB_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DAB_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAB_DATE__DOLLAR____AnalogSerialOutput__, DAB_DATE__DOLLAR__ );
    
    IPOD_LINE_0__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_0__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_0__DOLLAR____AnalogSerialOutput__, IPOD_LINE_0__DOLLAR__ );
    
    IPOD_LINE_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_1__DOLLAR____AnalogSerialOutput__, IPOD_LINE_1__DOLLAR__ );
    
    IPOD_LINE_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_2__DOLLAR____AnalogSerialOutput__, IPOD_LINE_2__DOLLAR__ );
    
    IPOD_LINE_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_3__DOLLAR____AnalogSerialOutput__, IPOD_LINE_3__DOLLAR__ );
    
    IPOD_LINE_4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_4__DOLLAR____AnalogSerialOutput__, IPOD_LINE_4__DOLLAR__ );
    
    IPOD_LINE_5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_5__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_5__DOLLAR____AnalogSerialOutput__, IPOD_LINE_5__DOLLAR__ );
    
    IPOD_LINE_6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_6__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_6__DOLLAR____AnalogSerialOutput__, IPOD_LINE_6__DOLLAR__ );
    
    IPOD_LINE_7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_7__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_7__DOLLAR____AnalogSerialOutput__, IPOD_LINE_7__DOLLAR__ );
    
    IPOD_LINE_8__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( IPOD_LINE_8__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPOD_LINE_8__DOLLAR____AnalogSerialOutput__, IPOD_LINE_8__DOLLAR__ );
    
    USB_NSA_LINE_0__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_0__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_0__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_0__DOLLAR__ );
    
    USB_NSA_LINE_1__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_1__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_1__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_1__DOLLAR__ );
    
    USB_NSA_LINE_2__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_2__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_2__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_2__DOLLAR__ );
    
    USB_NSA_LINE_3__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_3__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_3__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_3__DOLLAR__ );
    
    USB_NSA_LINE_4__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_4__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_4__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_4__DOLLAR__ );
    
    USB_NSA_LINE_5__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_5__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_5__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_5__DOLLAR__ );
    
    USB_NSA_LINE_6__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_6__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_6__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_6__DOLLAR__ );
    
    USB_NSA_LINE_7__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_7__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_7__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_7__DOLLAR__ );
    
    USB_NSA_LINE_8__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USB_NSA_LINE_8__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USB_NSA_LINE_8__DOLLAR____AnalogSerialOutput__, USB_NSA_LINE_8__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR__ );
    
    DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR__ );
    
    DIRECT_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DIRECT_COMMAND__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DIRECT_COMMAND__DOLLAR____AnalogSerialOutput__, DIRECT_COMMAND__DOLLAR__ );
    
    MUTE_MAIN__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MUTE_MAIN__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( MUTE_MAIN__DOLLAR____AnalogSerialOutput__, MUTE_MAIN__DOLLAR__ );
    
    DIRECT_KEY_AM_FM__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_AM_FM__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_AM_FM__DOLLAR____AnalogSerialInput__, DIRECT_KEY_AM_FM__DOLLAR__ );
    
    DIRECT_KEY_HD__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_HD__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_HD__DOLLAR____AnalogSerialInput__, DIRECT_KEY_HD__DOLLAR__ );
    
    DIRECT_KEY_XM__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_XM__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_XM__DOLLAR____AnalogSerialInput__, DIRECT_KEY_XM__DOLLAR__ );
    
    DIRECT_KEY_DAB__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( DIRECT_KEY_DAB__DOLLAR____AnalogSerialInput__, 12, this );
    m_StringInputList.Add( DIRECT_KEY_DAB__DOLLAR____AnalogSerialInput__, DIRECT_KEY_DAB__DOLLAR__ );
    
    FROMDEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROMDEVICE__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROMDEVICE__DOLLAR____AnalogSerialInput__, FROMDEVICE__DOLLAR__ );
    
    
    DIRECT_KEY_AM_FM__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_AM_FM__DOLLAR___OnChange_0, false ) );
    DIRECT_KEY_HD__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_HD__DOLLAR___OnChange_1, false ) );
    DIRECT_KEY_XM__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_XM__DOLLAR___OnChange_2, false ) );
    DIRECT_KEY_DAB__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( DIRECT_KEY_DAB__DOLLAR___OnChange_3, false ) );
    FROMDEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMDEVICE__DOLLAR___OnChange_4, false ) );
    SENDMAIN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDMAIN_OnPush_5, false ) );
    SENDZONE2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDZONE2_OnPush_6, false ) );
    SENDZONE3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENDZONE3_OnPush_7, false ) );
    ENTER_AM_FM.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_AM_FM_OnPush_8, false ) );
    ENTER_HD.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_HD_OnPush_9, false ) );
    ENTER_XM.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_XM_OnPush_10, false ) );
    ENTER_DAB.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_DAB_OnPush_11, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DENON_AVR_2308CI_2808CI_3808CI_4308CI_5805CI_888_988_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint AM_ENABLED__DigitalInput__ = 0;
const uint FM_ENABLED__DigitalInput__ = 1;
const uint AM_HD_ENABLED__DigitalInput__ = 2;
const uint FM_HD_ENABLED__DigitalInput__ = 3;
const uint SENDMAIN__DigitalInput__ = 4;
const uint SENDZONE2__DigitalInput__ = 5;
const uint SENDZONE3__DigitalInput__ = 6;
const uint IPOD__DigitalInput__ = 7;
const uint USB__DigitalInput__ = 8;
const uint ENTER_AM_FM__DigitalInput__ = 9;
const uint ENTER_HD__DigitalInput__ = 10;
const uint ENTER_XM__DigitalInput__ = 11;
const uint ENTER_DAB__DigitalInput__ = 12;
const uint DIRECT_KEY_AM_FM__DOLLAR____AnalogSerialInput__ = 0;
const uint DIRECT_KEY_HD__DOLLAR____AnalogSerialInput__ = 1;
const uint DIRECT_KEY_XM__DOLLAR____AnalogSerialInput__ = 2;
const uint DIRECT_KEY_DAB__DOLLAR____AnalogSerialInput__ = 3;
const uint FROMDEVICE__DOLLAR____AnalogSerialInput__ = 4;
const uint MAINLEVEL__AnalogSerialOutput__ = 0;
const uint ZONE2LEVEL__AnalogSerialOutput__ = 1;
const uint ZONE3LEVEL__AnalogSerialOutput__ = 2;
const uint MAINLEVEL__DOLLAR____AnalogSerialOutput__ = 3;
const uint ZONE2LEVEL__DOLLAR____AnalogSerialOutput__ = 4;
const uint ZONE3LEVEL__DOLLAR____AnalogSerialOutput__ = 5;
const uint FLLEVEL__DOLLAR____AnalogSerialOutput__ = 6;
const uint FRLEVEL__DOLLAR____AnalogSerialOutput__ = 7;
const uint CLEVEL__DOLLAR____AnalogSerialOutput__ = 8;
const uint SWLEVEL__DOLLAR____AnalogSerialOutput__ = 9;
const uint SLLEVEL__DOLLAR____AnalogSerialOutput__ = 10;
const uint SRLEVEL__DOLLAR____AnalogSerialOutput__ = 11;
const uint SBLLEVEL__DOLLAR____AnalogSerialOutput__ = 12;
const uint SBRLEVEL__DOLLAR____AnalogSerialOutput__ = 13;
const uint SBLEVEL__DOLLAR____AnalogSerialOutput__ = 14;
const uint ANALOG_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 15;
const uint HD_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 16;
const uint XM_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 17;
const uint DAB_TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 18;
const uint HD_STATION_NAME__DOLLAR____AnalogSerialOutput__ = 19;
const uint HD_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__ = 20;
const uint HD_SIGNAL__DOLLAR____AnalogSerialOutput__ = 21;
const uint HD_MULTICAST_CURRENT_CH__DOLLAR____AnalogSerialOutput__ = 22;
const uint HD_MULTICAST_CH__DOLLAR____AnalogSerialOutput__ = 23;
const uint HD_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__ = 24;
const uint HD_ARTIST__DOLLAR____AnalogSerialOutput__ = 25;
const uint HD_TITLE__DOLLAR____AnalogSerialOutput__ = 26;
const uint HD_ALBUM__DOLLAR____AnalogSerialOutput__ = 27;
const uint HD_GENRE__DOLLAR____AnalogSerialOutput__ = 28;
const uint XM_PRESET__DOLLAR____AnalogSerialOutput__ = 29;
const uint XM_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 30;
const uint XM_ARTIST__DOLLAR____AnalogSerialOutput__ = 31;
const uint XM_TITLE__DOLLAR____AnalogSerialOutput__ = 32;
const uint XM_RADIO_ID__DOLLAR____AnalogSerialOutput__ = 33;
const uint XM_SIGNAL__DOLLAR____AnalogSerialOutput__ = 34;
const uint DAB_STATION_NAME__DOLLAR____AnalogSerialOutput__ = 35;
const uint DAB_STATION_NAME_LONG__DOLLAR____AnalogSerialOutput__ = 36;
const uint DAB_ENSEMBLE__DOLLAR____AnalogSerialOutput__ = 37;
const uint DAB_PROGRAM_TYPE__DOLLAR____AnalogSerialOutput__ = 38;
const uint DAB_CHANNEL_CH__DOLLAR____AnalogSerialOutput__ = 39;
const uint DAB_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 40;
const uint DAB_MODE__DOLLAR____AnalogSerialOutput__ = 41;
const uint DAB_SIGNAL__DOLLAR____AnalogSerialOutput__ = 42;
const uint DAB_TIME__DOLLAR____AnalogSerialOutput__ = 43;
const uint DAB_DATE__DOLLAR____AnalogSerialOutput__ = 44;
const uint IPOD_LINE_0__DOLLAR____AnalogSerialOutput__ = 45;
const uint IPOD_LINE_1__DOLLAR____AnalogSerialOutput__ = 46;
const uint IPOD_LINE_2__DOLLAR____AnalogSerialOutput__ = 47;
const uint IPOD_LINE_3__DOLLAR____AnalogSerialOutput__ = 48;
const uint IPOD_LINE_4__DOLLAR____AnalogSerialOutput__ = 49;
const uint IPOD_LINE_5__DOLLAR____AnalogSerialOutput__ = 50;
const uint IPOD_LINE_6__DOLLAR____AnalogSerialOutput__ = 51;
const uint IPOD_LINE_7__DOLLAR____AnalogSerialOutput__ = 52;
const uint IPOD_LINE_8__DOLLAR____AnalogSerialOutput__ = 53;
const uint USB_NSA_LINE_0__DOLLAR____AnalogSerialOutput__ = 54;
const uint USB_NSA_LINE_1__DOLLAR____AnalogSerialOutput__ = 55;
const uint USB_NSA_LINE_2__DOLLAR____AnalogSerialOutput__ = 56;
const uint USB_NSA_LINE_3__DOLLAR____AnalogSerialOutput__ = 57;
const uint USB_NSA_LINE_4__DOLLAR____AnalogSerialOutput__ = 58;
const uint USB_NSA_LINE_5__DOLLAR____AnalogSerialOutput__ = 59;
const uint USB_NSA_LINE_6__DOLLAR____AnalogSerialOutput__ = 60;
const uint USB_NSA_LINE_7__DOLLAR____AnalogSerialOutput__ = 61;
const uint USB_NSA_LINE_8__DOLLAR____AnalogSerialOutput__ = 62;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_AM_FM__DOLLAR____AnalogSerialOutput__ = 63;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_XM__DOLLAR____AnalogSerialOutput__ = 64;
const uint DIRECT_COMMAND_VALUE_DISPLAYED_DAB__DOLLAR____AnalogSerialOutput__ = 65;
const uint DIRECT_COMMAND__DOLLAR____AnalogSerialOutput__ = 66;
const uint MUTE_MAIN__DOLLAR____AnalogSerialOutput__ = 67;

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
