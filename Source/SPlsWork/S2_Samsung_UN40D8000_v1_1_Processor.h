#ifndef __S2_SAMSUNG_UN40D8000_V1_1_PROCESSOR_H__
#define __S2_SAMSUNG_UN40D8000_V1_1_PROCESSOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Samsung_UN40D8000_v1_1_Processor_ATV_DIG_INPUT 0
#define __S2_Samsung_UN40D8000_v1_1_Processor_DTV_DIG_INPUT 1

#define __S2_Samsung_UN40D8000_v1_1_Processor_KP_DIG_INPUT 2
#define __S2_Samsung_UN40D8000_v1_1_Processor_KP_ARRAY_LENGTH 13

/*
* ANALOG_INPUT
*/
#define __S2_Samsung_UN40D8000_v1_1_Processor_VOLUME_SET_VALUE_ANALOG_INPUT 0
#define __S2_Samsung_UN40D8000_v1_1_Processor_THREED_VIEW_POINT_VALUE_ANALOG_INPUT 1
#define __S2_Samsung_UN40D8000_v1_1_Processor_THREED_DEPTH_VALUE_ANALOG_INPUT 2

#define __S2_Samsung_UN40D8000_v1_1_Processor_STRING_TO_SEND_STRING_INPUT 3
#define __S2_Samsung_UN40D8000_v1_1_Processor_STRING_TO_SEND_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STRING_TO_SEND, __S2_Samsung_UN40D8000_v1_1_Processor_STRING_TO_SEND_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_Samsung_UN40D8000_v1_1_Processor_CHANNEL_TEXT_STRING_OUTPUT 0
#define __S2_Samsung_UN40D8000_v1_1_Processor_VOLUME_TEXT_STRING_OUTPUT 1
#define __S2_Samsung_UN40D8000_v1_1_Processor_TO_DEVICE_STRING_OUTPUT 2


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_Samsung_UN40D8000_v1_1_Processor_STEMP_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STEMP, __S2_Samsung_UN40D8000_v1_1_Processor_STEMP_STRING_MAX_LEN );
#define __S2_Samsung_UN40D8000_v1_1_Processor_SVOLUMETEMP_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SVOLUMETEMP, __S2_Samsung_UN40D8000_v1_1_Processor_SVOLUMETEMP_STRING_MAX_LEN );
#define __S2_Samsung_UN40D8000_v1_1_Processor_STHREEDVIEWPOINTTEMP_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDVIEWPOINTTEMP, __S2_Samsung_UN40D8000_v1_1_Processor_STHREEDVIEWPOINTTEMP_STRING_MAX_LEN );
#define __S2_Samsung_UN40D8000_v1_1_Processor_STHREEDDEPTHTEMP_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDDEPTHTEMP, __S2_Samsung_UN40D8000_v1_1_Processor_STHREEDDEPTHTEMP_STRING_MAX_LEN );
#define __S2_Samsung_UN40D8000_v1_1_Processor_SCHANNELTEMP_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELTEMP, __S2_Samsung_UN40D8000_v1_1_Processor_SCHANNELTEMP_STRING_MAX_LEN );
#define __S2_Samsung_UN40D8000_v1_1_Processor_SNUMBER_STRING_MAX_LEN 11
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER, __S2_Samsung_UN40D8000_v1_1_Processor_SNUMBER_STRING_MAX_LEN );
#define __S2_Samsung_UN40D8000_v1_1_Processor_SCHANNELCOMMAND_STRING_MAX_LEN 13
CREATE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND, __S2_Samsung_UN40D8000_v1_1_Processor_SCHANNELCOMMAND_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __KP );
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STRING_TO_SEND );
};

START_NVRAM_VAR_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor )
{
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STEMP );
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SVOLUMETEMP );
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDVIEWPOINTTEMP );
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __STHREEDDEPTHTEMP );
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELTEMP );
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SNUMBER );
   DECLARE_STRING_STRUCT( S2_Samsung_UN40D8000_v1_1_Processor, __SCHANNELCOMMAND );
   unsigned short __ISEMAPHORE;
   unsigned short __A;
   unsigned short __ICS;
   unsigned short __IENABLECHANGE;
   unsigned short __ILOC;
   unsigned short __IMAINCHANNEL;
   unsigned short __ISUBCHANNEL;
};

DEFINE_WAITEVENT( S2_Samsung_UN40D8000_v1_1_Processor, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_SAMSUNG_UN40D8000_V1_1_PROCESSOR_H__

