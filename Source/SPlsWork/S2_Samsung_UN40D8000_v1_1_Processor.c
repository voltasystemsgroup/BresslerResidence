#include "TypeDefs.h"
#include "Globals.h"
#include "FnctList.h"
#include "Library.h"
#include "SimplSig.h"
#include "S2_Samsung_UN40D8000_v1_1_Processor.h"

FUNCTION_MAIN( S2_Samsung_UN40D8000_v1_1_Processor );
EVENT_HANDLER( S2_Samsung_UN40D8000_v1_1_Processor );
DEFINE_ENTRYPOINT( S2_Samsung_UN40D8000_v1_1_Processor );


static struct StringHdr_s* S2_Samsung_UN40D8000_v1_1_Processor__SENDSTRING ( struct StringHdr_s*  __FN_DSTRET_STR__  , struct StringHdr_s* __STRINGSEND ) 
    { 
    /* Begin local function variable declarations */
    
    unsigned short  __A; 
    unsigned short  __ICS; 
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SSTRINGFINAL, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SSTRINGFINAL );
    
    short __FN_FOREND_VAL__1; 
    short __FN_FORINIT_VAL__1; 
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    
    CheckStack( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SSTRINGFINAL );
    INITIALIZE_LOCAL_STRING_STRUCT( __SSTRINGFINAL, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 136 );
    __ICS = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 137 );
    __FN_FOREND_VAL__1 = Len( LOCAL_STRING_STRUCT( __STRINGSEND  )  ); 
    __FN_FORINIT_VAL__1 = 1; 
    for( __A = 1; (__FN_FORINIT_VAL__1 > 0)  ? ((short)__A  <= __FN_FOREND_VAL__1 ) : ((short)__A  >= __FN_FOREND_VAL__1) ; __A  += __FN_FORINIT_VAL__1) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 139 );
        __ICS = (__ICS + Byte( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , LOCAL_STRING_STRUCT( __STRINGSEND  )  , __A )); 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 137 );
        } 
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 141 );
    __ICS = (256 - __ICS); 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 142 );
    FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,4 , "%s%s"  , LOCAL_STRING_STRUCT( __STRINGSEND  )  ,  Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , __ICS)  )  ; 
    FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , LOCAL_STRING_STRUCT( __SSTRINGFINAL  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 143 );
    FormatString( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ),  __FN_DSTRET_STR__, 2, "%s", ( LOCAL_STRING_STRUCT( __SSTRINGFINAL  )  ) );
    goto S2_Samsung_UN40D8000_v1_1_Processor_Exit__SENDSTRING ; 
    
    S2_Samsung_UN40D8000_v1_1_Processor_Exit__SENDSTRING:
/* Begin Free local function variables */
    FREE_LOCAL_STRING_STRUCT( __SSTRINGFINAL );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
    FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
    /* End Free local function variables */
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 151 );
    return __FN_DSTRET_STR__; 
    }
    
DEFINE_INDEPENDENT_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00000 /*String_To_Send*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 153 );
    Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ICS = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 154 );
    if ( (Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ISEMAPHORE == 0)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 156 );
        Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ISEMAPHORE = 1; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 157 );
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,2 , "%s"  , GLOBAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STRING_TO_SEND  )   )  ; 
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STEMP  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 158 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,2 , "%s"  , S2_Samsung_UN40D8000_v1_1_Processor__SENDSTRING (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  (struct StringHdr_s* )  NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STEMP  )  )  )  ; 
        SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_TO_DEVICE_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 159 );
        Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ISEMAPHORE = 0; 
        } 
    
    
    S2_Samsung_UN40D8000_v1_1_Processor_Exit__Event_0:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00001 /*Volume_Set_Value*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 164 );
    if ( (Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IENABLECHANGE == 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 166 );
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,7 , "\x08""\x22""\x01""\x00""\x00""%s"  , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GetAnalogInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_VOLUME_SET_VALUE_ANALOG_INPUT ))  )  ; 
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SVOLUMETEMP  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 167 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,2 , "%s"  , S2_Samsung_UN40D8000_v1_1_Processor__SENDSTRING (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  (struct StringHdr_s* )  NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SVOLUMETEMP  )  )  )  ; 
        SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_TO_DEVICE_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
        
        ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 168 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,2 , "%s"  , Itoa ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GetAnalogInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_VOLUME_SET_VALUE_ANALOG_INPUT ))  )  ; 
        SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_VOLUME_TEXT_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
        
        ; 
        } 
    
    
    S2_Samsung_UN40D8000_v1_1_Processor_Exit__Event_1:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00002 /*ThreeD_View_Point_Value*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 174 );
    if ( (Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IENABLECHANGE == 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 176 );
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,7 , "\x08""\x22""\x0B""\x0C""\x02""%s"  , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GetAnalogInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_THREED_VIEW_POINT_VALUE_ANALOG_INPUT ))  )  ; 
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDVIEWPOINTTEMP  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 177 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,2 , "%s"  , S2_Samsung_UN40D8000_v1_1_Processor__SENDSTRING (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  (struct StringHdr_s* )  NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDVIEWPOINTTEMP  )  )  )  ; 
        SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_TO_DEVICE_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
        
        ; 
        } 
    
    
    S2_Samsung_UN40D8000_v1_1_Processor_Exit__Event_2:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00003 /*ThreeD_Depth_Value*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 183 );
    if ( (Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IENABLECHANGE == 1)) 
        { 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 185 );
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,7 , "\x08""\x22""\x0B""\x0C""\x03""%s"  , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , GetAnalogInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_THREED_DEPTH_VALUE_ANALOG_INPUT ))  )  ; 
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDDEPTHTEMP  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 186 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,2 , "%s"  , S2_Samsung_UN40D8000_v1_1_Processor__SENDSTRING (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  (struct StringHdr_s* )  NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDDEPTHTEMP  )  )  )  ; 
        SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_TO_DEVICE_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
        
        ; 
        } 
    
    
    S2_Samsung_UN40D8000_v1_1_Processor_Exit__Event_3:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}

DEFINE_INDEPENDENT_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00004 /*KP*/ )

    {
    /* Begin local function variable declarations */
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SPLS_TMPVAR__LOCALSTR_0__, sizeof( "-" ) );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SPLS_TMPVAR__LOCALSTR_0__ );
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    
    CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__2, 50 );
    DECLARE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__2 );
    
    SAVE_GLOBAL_POINTERS ;
    CheckStack( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SPLS_TMPVAR__LOCALSTR_0__ );
    SET_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__, "-" );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__ );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__1 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__1, 50 );
    
    ALLOCATE_LOCAL_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __FN_DST_STR__2 );
    INITIALIZE_LOCAL_STRING_STRUCT( __FN_DST_STR__2, 50 );
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 192 );
    
        {
        int __SPLS_TMPVAR__SWTCH_1__ = ( GetLocalLastModifiedArrayIndex ( S2_Samsung_UN40D8000_v1_1_Processor )) ;
        
            { 
            if ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 195 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s0"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 197 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s1"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 199 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s2"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 201 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s3"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 203 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s4"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 205 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s5"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 207 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s6"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 209 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s7"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 211 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s8"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) )
                {
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 213 );
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s9"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                }
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 216 );
                Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ILOC = Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  , 1 , 1 ); 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 217 );
                if ( ((Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ILOC == 0) && (Len( NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  ) > 0))) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 219 );
                    FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,3 , "%s-"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
                    FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   ,2 , "%s"  , __FN_DST_STR__ ) ; 
                    } 
                
                } 
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 224 );
                ClearBuffer ( NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  ) ; 
                } 
            
            else if ( __SPLS_TMPVAR__SWTCH_1__ == ( 13) )
                { 
                UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 228 );
                if ( (Len( NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  ) > 0)) 
                    { 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 230 );
                    if ( Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  , 1 , 1 )) 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 232 );
                        Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IMAINCHANNEL = Atoi( Left( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , LOCAL_STRING_STRUCT( __FN_DST_STR__ )  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  , (Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  , 1 , 1 ) - 1) ) ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 233 );
                        Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ISUBCHANNEL = Atoi( Right( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , LOCAL_STRING_STRUCT( __FN_DST_STR__ )  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  , (Len( NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  ) - Find( LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ )  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  , 1 , 1 )) ) ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 234 );
                        if ( GetDigitalInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_ATV_DIG_INPUT )) 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 235 );
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,7 , "\x08""\x22""\x04""\x00""\x00""%s"  , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IMAINCHANNEL)  )  ; 
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                            }
                        
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 236 );
                        if ( GetDigitalInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_DTV_DIG_INPUT )) 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 237 );
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__2 )    ,8 , "\x08""\x22""\x04""\x80""%s%s"  , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IMAINCHANNEL * 4)) , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    , Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ISUBCHANNEL)  )  ; 
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND  )   ,2 , "%s"  , __FN_DST_STR__2 ) ; 
                            }
                        
                        } 
                    
                    else 
                        { 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 241 );
                        Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IMAINCHANNEL = Atoi( NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  ); 
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 243 );
                        if ( GetDigitalInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_ATV_DIG_INPUT )) 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 244 );
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,7 , "\x08""\x22""\x04""\x00""\x00""%s"  , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IMAINCHANNEL)  )  ; 
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                            }
                        
                        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 245 );
                        if ( GetDigitalInput( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_DTV_DIG_INPUT )) 
                            {
                            UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 246 );
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ,  LOCAL_STRING_STRUCT( __FN_DST_STR__1 )    ,7 , "\x08""\x22""\x04""\x80""%s\x00"""  , Chr (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    , (Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IMAINCHANNEL * 4))  )  ; 
                            FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND  )   ,2 , "%s"  , __FN_DST_STR__1 ) ; 
                            }
                        
                        } 
                    
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 248 );
                    if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
                    FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,2 , "%s"  , S2_Samsung_UN40D8000_v1_1_Processor__SENDSTRING (  LOCAL_STRING_STRUCT( __FN_DST_STR__ )    ,  (struct StringHdr_s* )  NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND  )  )  )  ; 
                    SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_TO_DEVICE_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
                    ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
                    
                    ; 
                    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 249 );
                    ClearBuffer ( NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  ) ; 
                    } 
                
                } 
            
            } 
            
        }
        
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 253 );
    if ( (Len( NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )  ) > 0)) 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 254 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,2 , "%s"  , NVRAM_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER  )   )  ; 
        SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_CHANNEL_TEXT_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
        
        ; 
        }
    
    else 
        {
        UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 256 );
        if( ObtainStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ) == 0 ) {
        FormatString ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) , GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor )  ,1 , "\x20"""  )  ; 
        SetSerial( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), __S2_Samsung_UN40D8000_v1_1_Processor_CHANNEL_TEXT_STRING_OUTPUT, GENERIC_STRING_OUTPUT( S2_Samsung_UN40D8000_v1_1_Processor ) );
        ReleaseStringOutputSemaphore( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); }
        
        ; 
        }
    
    
    S2_Samsung_UN40D8000_v1_1_Processor_Exit__Event_4:
    /* Begin Free local function variables */
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__ );
FREE_LOCAL_STRING_STRUCT( __SPLS_TMPVAR__LOCALSTR_0__ );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__1 );
FREE_LOCAL_STRING_STRUCT( __FN_DST_STR__2 );
/* End Free local function variables */
RESTORE_GLOBAL_POINTERS ;

}


    
    
DEFINE_WAITEVENT( S2_Samsung_UN40D8000_v1_1_Processor, __SPLS_TMPVAR__WAITLABEL_0__ )
    {
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    
    
    /* End local function variable declarations */
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 273 );
    Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IENABLECHANGE = 1; 
    

S2_Samsung_UN40D8000_v1_1_Processor_Exit____SPLS_TMPVAR__WAITLABEL_0__:
    
    /* Begin Free local function variables */
    /* End Free local function variables */
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }

/********************************************************************************
  Constructor
********************************************************************************/

/********************************************************************************
  Destructor
********************************************************************************/

/********************************************************************************
  static void ProcessDigitalEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessDigitalEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        case __S2_Samsung_UN40D8000_v1_1_Processor_KP_DIG_INPUT :
            if ( Signal->Value /*Push*/ )
            {
                SAFESPAWN_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00004 /*KP*/, 0 );
                
            }
            else /*Release*/
            {
                SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
                
            }
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessAnalogEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessAnalogEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        case __S2_Samsung_UN40D8000_v1_1_Processor_VOLUME_SET_VALUE_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00001 /*Volume_Set_Value*/, 0 );
            break;
            
        case __S2_Samsung_UN40D8000_v1_1_Processor_THREED_VIEW_POINT_VALUE_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00002 /*ThreeD_View_Point_Value*/, 0 );
            break;
            
        case __S2_Samsung_UN40D8000_v1_1_Processor_THREED_DEPTH_VALUE_ANALOG_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00003 /*ThreeD_Depth_Value*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessStringEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessStringEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Samsung_UN40D8000_v1_1_Processor ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        case __S2_Samsung_UN40D8000_v1_1_Processor_STRING_TO_SEND_STRING_INPUT :
            SAFESPAWN_EVENTHANDLER( S2_Samsung_UN40D8000_v1_1_Processor, 00000 /*String_To_Send*/, 0 );
            break;
            
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketConnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketConnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketDisconnectEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketReceiveEvent( struct Signal_s *Signal )
{
    if ( UPDATE_INPUT_STRING( S2_Samsung_UN40D8000_v1_1_Processor ) == 1 ) return ;
    
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  static void ProcessSocketStatusEvent( struct Signal_s *Signal )
********************************************************************************/
static void ProcessSocketStatusEvent( struct Signal_s *Signal )
{
    switch ( Signal->SignalNumber )
    {
        default :
            SetSymbolEventStart ( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ) ); 
            break ;
        
    }
}

/********************************************************************************
  EVENT_HANDLER( S2_Samsung_UN40D8000_v1_1_Processor )
********************************************************************************/
EVENT_HANDLER( S2_Samsung_UN40D8000_v1_1_Processor )
    {
    SAVE_GLOBAL_POINTERS ;
    CHECK_INPUT_ARRAY ( S2_Samsung_UN40D8000_v1_1_Processor, __KP ) ;
    switch ( Signal->Type )
        {
        case e_SIGNAL_TYPE_DIGITAL :
            ProcessDigitalEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_ANALOG :
            ProcessAnalogEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STRING :
            ProcessStringEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_CONNECT :
            ProcessSocketConnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_DISCONNECT :
            ProcessSocketDisconnectEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_RECEIVE :
            ProcessSocketReceiveEvent( Signal );
            break ;
        case e_SIGNAL_TYPE_STATUS :
            ProcessSocketStatusEvent( Signal );
            break ;
        }
        
    RESTORE_GLOBAL_POINTERS ;
    
    }
    
/********************************************************************************
  FUNCTION_MAIN( S2_Samsung_UN40D8000_v1_1_Processor )
********************************************************************************/
FUNCTION_MAIN( S2_Samsung_UN40D8000_v1_1_Processor )
{
    /* Begin local function variable declarations */
    
    SAVE_GLOBAL_POINTERS ;
    SET_INSTANCE_POINTER ( S2_Samsung_UN40D8000_v1_1_Processor );
    
    
    /* End local function variable declarations */
    
    INITIALIZE_IO_ARRAY ( S2_Samsung_UN40D8000_v1_1_Processor, __KP, IO_TYPE_DIGITAL_INPUT, __S2_Samsung_UN40D8000_v1_1_Processor_KP_DIG_INPUT, __S2_Samsung_UN40D8000_v1_1_Processor_KP_ARRAY_LENGTH );
    
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __STRING_TO_SEND, e_INPUT_TYPE_STRING, __S2_Samsung_UN40D8000_v1_1_Processor_STRING_TO_SEND_STRING_MAX_LEN );
    REGISTER_GLOBAL_INPUT_STRING ( S2_Samsung_UN40D8000_v1_1_Processor, __STRING_TO_SEND, __S2_Samsung_UN40D8000_v1_1_Processor_STRING_TO_SEND_STRING_INPUT );
    
    INITIALIZE_NVRAM_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __STEMP, e_INPUT_TYPE_NONE, __S2_Samsung_UN40D8000_v1_1_Processor_STEMP_STRING_MAX_LEN );
    INITIALIZE_NVRAM_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __SVOLUMETEMP, e_INPUT_TYPE_NONE, __S2_Samsung_UN40D8000_v1_1_Processor_SVOLUMETEMP_STRING_MAX_LEN );
    INITIALIZE_NVRAM_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDVIEWPOINTTEMP, e_INPUT_TYPE_NONE, __S2_Samsung_UN40D8000_v1_1_Processor_STHREEDVIEWPOINTTEMP_STRING_MAX_LEN );
    INITIALIZE_NVRAM_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDDEPTHTEMP, e_INPUT_TYPE_NONE, __S2_Samsung_UN40D8000_v1_1_Processor_STHREEDDEPTHTEMP_STRING_MAX_LEN );
    INITIALIZE_NVRAM_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELTEMP, e_INPUT_TYPE_NONE, __S2_Samsung_UN40D8000_v1_1_Processor_SCHANNELTEMP_STRING_MAX_LEN );
    INITIALIZE_NVRAM_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER, e_INPUT_TYPE_NONE, __S2_Samsung_UN40D8000_v1_1_Processor_SNUMBER_STRING_MAX_LEN );
    INITIALIZE_NVRAM_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND, e_INPUT_TYPE_NONE, __S2_Samsung_UN40D8000_v1_1_Processor_SCHANNELCOMMAND_STRING_MAX_LEN );
    INITIALIZE_GLOBAL_STRING_STRUCT ( S2_Samsung_UN40D8000_v1_1_Processor, sGenericOutStr, e_INPUT_TYPE_NONE, GENERIC_STRING_OUTPUT_LEN );
    
    
    
    
    
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 269 );
    Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__IENABLECHANGE = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 270 );
    Nvram->S2_Samsung_UN40D8000_v1_1_Processor.__ISEMAPHORE = 0; 
    UpdateSourceCodeLine( INSTANCE_PTR( S2_Samsung_UN40D8000_v1_1_Processor ), 271 );
    CREATE_WAIT( S2_Samsung_UN40D8000_v1_1_Processor, 100, __SPLS_TMPVAR__WAITLABEL_0__ );
    
    
    S2_Samsung_UN40D8000_v1_1_Processor_Exit__MAIN:/* Begin Free local function variables */
    /* End Free local function variables */
    
    RESTORE_GLOBAL_POINTERS ;
    return 0 ;
    }
