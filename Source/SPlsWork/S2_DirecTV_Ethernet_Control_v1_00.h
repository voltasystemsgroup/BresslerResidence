#ifndef __S2_DIRECTV_ETHERNET_CONTROL_V1_00_H__
#define __S2_DIRECTV_ETHERNET_CONTROL_V1_00_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_DirecTV_Ethernet_Control_v1_00_POWER_DIG_INPUT 0
#define __S2_DirecTV_Ethernet_Control_v1_00_POWER_ON_DIG_INPUT 1
#define __S2_DirecTV_Ethernet_Control_v1_00_POWER_OFF_DIG_INPUT 2
#define __S2_DirecTV_Ethernet_Control_v1_00_FORMAT_DIG_INPUT 3
#define __S2_DirecTV_Ethernet_Control_v1_00_PAUSE_DIG_INPUT 4
#define __S2_DirecTV_Ethernet_Control_v1_00_REW_DIG_INPUT 5
#define __S2_DirecTV_Ethernet_Control_v1_00_REPLAY_DIG_INPUT 6
#define __S2_DirecTV_Ethernet_Control_v1_00_STOP_DIG_INPUT 7
#define __S2_DirecTV_Ethernet_Control_v1_00_ADVANCE_DIG_INPUT 8
#define __S2_DirecTV_Ethernet_Control_v1_00_FFWD_DIG_INPUT 9
#define __S2_DirecTV_Ethernet_Control_v1_00_REC_DIG_INPUT 10
#define __S2_DirecTV_Ethernet_Control_v1_00_PLAY_DIG_INPUT 11
#define __S2_DirecTV_Ethernet_Control_v1_00_GUIDE_DIG_INPUT 12
#define __S2_DirecTV_Ethernet_Control_v1_00_ACTIVE_DIG_INPUT 13
#define __S2_DirecTV_Ethernet_Control_v1_00_LIST_DIG_INPUT 14
#define __S2_DirecTV_Ethernet_Control_v1_00_EXIT_DIG_INPUT 15
#define __S2_DirecTV_Ethernet_Control_v1_00_BACK_DIG_INPUT 16
#define __S2_DirecTV_Ethernet_Control_v1_00_MENU_DIG_INPUT 17
#define __S2_DirecTV_Ethernet_Control_v1_00_INFO_DIG_INPUT 18
#define __S2_DirecTV_Ethernet_Control_v1_00_NAV_UP_DIG_INPUT 19
#define __S2_DirecTV_Ethernet_Control_v1_00_NAV_DOWN_DIG_INPUT 20
#define __S2_DirecTV_Ethernet_Control_v1_00_NAV_LEFT_DIG_INPUT 21
#define __S2_DirecTV_Ethernet_Control_v1_00_NAV_RIGHT_DIG_INPUT 22
#define __S2_DirecTV_Ethernet_Control_v1_00_SELECT_DIG_INPUT 23
#define __S2_DirecTV_Ethernet_Control_v1_00_RED_DIG_INPUT 24
#define __S2_DirecTV_Ethernet_Control_v1_00_GREEN_DIG_INPUT 25
#define __S2_DirecTV_Ethernet_Control_v1_00_YELLOW_DIG_INPUT 26
#define __S2_DirecTV_Ethernet_Control_v1_00_BLUE_DIG_INPUT 27
#define __S2_DirecTV_Ethernet_Control_v1_00_CH_UP_DIG_INPUT 28
#define __S2_DirecTV_Ethernet_Control_v1_00_CH_DOWN_DIG_INPUT 29
#define __S2_DirecTV_Ethernet_Control_v1_00_PREV_DIG_INPUT 30
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_0_DIG_INPUT 31
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_1_DIG_INPUT 32
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_2_DIG_INPUT 33
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_3_DIG_INPUT 34
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_4_DIG_INPUT 35
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_5_DIG_INPUT 36
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_6_DIG_INPUT 37
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_7_DIG_INPUT 38
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_8_DIG_INPUT 39
#define __S2_DirecTV_Ethernet_Control_v1_00_DIGIT_9_DIG_INPUT 40
#define __S2_DirecTV_Ethernet_Control_v1_00_DASH_DIG_INPUT 41
#define __S2_DirecTV_Ethernet_Control_v1_00_ENTER_DIG_INPUT 42


/*
* ANALOG_INPUT
*/
#define __S2_DirecTV_Ethernet_Control_v1_00_CHANNEL_ANALOG_INPUT 0




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/



/*
* Direct Socket Variables
*/

#define __S2_DirecTV_Ethernet_Control_v1_00_DTV_COMMAND_TCPCLIENT_SOCKET 2
#define __S2_DirecTV_Ethernet_Control_v1_00_DTV_COMMAND_TCPCLIENT_STRING_MAX_LEN 4096
START_SOCKET_DEFINITION( S2_DirecTV_Ethernet_Control_v1_00, __DTV_COMMAND_TCPCLIENT )
{
   int SocketStatus;
   enum ESplusSocketType eSocketType;
   int SocketID;
   void *SocketPtr;
CREATE_SOCKET_STRING( S2_DirecTV_Ethernet_Control_v1_00, SocketRxBuf, __S2_DirecTV_Ethernet_Control_v1_00_DTV_COMMAND_TCPCLIENT_STRING_MAX_LEN );
};



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
#define __S2_DirecTV_Ethernet_Control_v1_00_IPA_STRING_PARAMETER 10
#define __S2_DirecTV_Ethernet_Control_v1_00_IPA_PARAM_MAX_LEN 16
CREATE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_00, __IPA, __S2_DirecTV_Ethernet_Control_v1_00_IPA_PARAM_MAX_LEN );


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
#define __S2_DirecTV_Ethernet_Control_v1_00_GSCOMMAND_STRING_MAX_LEN 32
CREATE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_00, __GSCOMMAND, __S2_DirecTV_Ethernet_Control_v1_00_GSCOMMAND_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_DirecTV_Ethernet_Control_v1_00 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_00, __GSCOMMAND );
   DECLARE_SOCKET( S2_DirecTV_Ethernet_Control_v1_00, __DTV_COMMAND_TCPCLIENT );
   DECLARE_STRING_STRUCT( S2_DirecTV_Ethernet_Control_v1_00, __IPA );
};

START_NVRAM_VAR_STRUCT( S2_DirecTV_Ethernet_Control_v1_00 )
{
};



#endif //__S2_DIRECTV_ETHERNET_CONTROL_V1_00_H__

