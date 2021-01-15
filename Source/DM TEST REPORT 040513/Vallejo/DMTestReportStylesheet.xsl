<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" exclude-result-prefixes="msxsl" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt">
  <xsl:output method="html" indent="yes"/>

  <xsl:variable name="var_AllTables_BackgroundColor"><!--"#9acd32"-->"#9acd32"</xsl:variable>
  <xsl:variable name="var_Table_CheckMark_Symbol">&#8730;</xsl:variable>
  <xsl:variable name="var_Table_CheckMark_Color">"#008800"</xsl:variable>
  <xsl:variable name="var_Table_CheckMark_BackgroundColor">"#eeffee"</xsl:variable>
  <xsl:variable name="var_Table_PreferredMark_Symbol">P</xsl:variable>
  <xsl:variable name="var_Table_PreferredMark_Color">"#dd0000"</xsl:variable>
  <xsl:variable name="var_Table_PreferredMark_BackgroundColor">"#ffeeee"</xsl:variable>
  
  <xsl:variable name="var_ShowTable_ConnectedDevices">
	<xsl:choose>
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'HD-MD8x2'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'HD-MD8x1'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'DM-MD6x1'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:otherwise>TRUE</xsl:otherwise> <!-- MUST be in a single line to avoid extra spaces in the value -->
	</xsl:choose>
  </xsl:variable>

  <xsl:variable name="var_ShowTable_LinkReport">
    <xsl:choose>
      <xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'HD-MD8x2'">FALSE</xsl:when>
      <!-- MUST be in a single line to avoid extra spaces in the value -->
      <xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'HD-MD8x1'">FALSE</xsl:when>
      <!-- MUST be in a single line to avoid extra spaces in the value -->
      <xsl:otherwise>TRUE</xsl:otherwise>
      <!-- MUST be in a single line to avoid extra spaces in the value -->
    </xsl:choose>
  </xsl:variable>

  <xsl:variable name="var_ShowTable_VideoTimingAndAudioOnLoopOutputs">
	<xsl:choose>
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'HD-MD8x2'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'HD-MD8x1'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'DM-MD6x1'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'DM-MD6x4'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:when test="/DigitalMediaTestReport/ProjectInfo/FirmwareName = 'DM-MD6x6'">FALSE</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
		<xsl:otherwise>TRUE</xsl:otherwise> <!-- MUST be in a single line to avoid extra spaces in the value -->
	</xsl:choose>
  </xsl:variable>

  <!--
  <xsl:variable name="BrowserVendor" select="system-property('xsl:vendor')" />
  <xsl:variable name="IsMicrosoftBrowser" select="contains($BrowserVendor, 'Microsoft')"/>
  -->

    
    
  <xsl:template match="DigitalMediaTestReport">
    <html>
      <head>
        <link rel="stylesheet" type="text/css" href="DMTestReportStyles.css"/>
      </head>
      <body>
        <!--<h1 style="color:red">Browser's Vendor: <xsl:value-of select="$BrowserVendor"/>;   IsMicrosoftBrowser: <xsl:value-of select="$IsMicrosoftBrowser"/> </h1>-->

		    <xsl:apply-templates select="ProjectInfo"/>
        <xsl:apply-templates select="TestReports"/>

        <h1> </h1>
        <h1> </h1>
        <hr></hr>
        

        <h1> </h1>
        <h1> </h1>
        <h1> </h1>
        <h1> </h1>
        <hr></hr>
        <hr></hr>
        <xsl:call-template name= "Appendix_A" />
        <hr></hr>
        <xsl:call-template name= "Appendix_B" />
        <hr></hr>
        <xsl:call-template name= "Appendix_C" />

        <!--
        &#60;&#33;&#45;&#45;
        <xsl:call-template name= "CopySorceXmlDocument" />
        &#45;&#45;&#62;
        -->
		
      </body>
    </html>
  </xsl:template>
    
    <xsl:template match="ProjectInfo">
        <table class="coverpage">
            <tr><td>
        <Table class="coverpageleft">
            <tr><td>
              <!--xsl:call-template name="DM_Image_Source_narrow">
			        </xsl:call-template-->
								<image src="DM.jpg" width="160"></image>
            </td></tr>
            <tr><td height="730"><div class="verticalText"><br/>TEST REPORT</div></td></tr>
            <tr><td>
                <div class="generaltext">
                <b><xsl:value-of select="Integrator/IntegratorName"/></b><br></br>
                <xsl:value-of select="Integrator/IntegratorAddress1"/><br></br>
                <xsl:value-of select="Integrator/IntegratorAddress2"/><br></br>
                <xsl:value-of select="Integrator/IntegratorPhone"/>
                    </div>
			</td></tr>
		</Table>
                </td>
            <td>
                        <div class="title">
            <br></br><br></br><br></br><br></br>
		AV SYSTEM TEST REPORT</div>
        <br></br><br></br>
        <div class="subtitle">PERFORMANCE TESTING FOR DIGITAL VIDEO AND AUDIO DISTRIBUTION
        <br></br><br></br>
        Project Name: <xsl:value-of select="ProjectName"/>
            <br></br>Unit Under Test: <xsl:value-of select="UnitUnderTest"/>
            <br></br>Unit Serial Number: <xsl:value-of select="SerialNumber"/><br></br><br></br><br></br>
            
            Report generated on: <xsl:value-of select="DateTime"/>
            <br></br><br></br><br></br><br></br>
            Prepared for:
            <xsl:value-of select="Client/ClientName"/><br></br>
            <xsl:value-of select="Client/ClientAddress1"/><br></br>
            <xsl:value-of select="Client/ClientAddress2"/><br></br>
            <xsl:value-of select="Client/ClientPhone"/><br></br>
		<br></br><br></br>
            on behalf of:
            <xsl:value-of select="SystemDesigner/SystemDesignerName"/><br></br>
            <xsl:value-of select="SystemDesigner/SystemDesignerAddress1"/><br></br>
            <xsl:value-of select="SystemDesigner/SystemDesignerAddress2"/><br></br>
            <xsl:value-of select="SystemDesigner/SystemDesignerPhone"/><br></br>
            </div>
                
			</td>
            </tr>
        </table>
        
<Table class="abstract">
    <tr><th colspan="2">
      <!--xsl:call-template name="DM_Image_Source">
			</xsl:call-template-->
	
	<image src="DM.jpg" width="500" align="center"></image>
    </th></tr>
    <tr><th colspan="2">
         <h1>
             Test Report <xsl:value-of select="Heading1"/>
         </h1></th></tr>
    <tr><td colspan="2">
        This report is a summary of the results of the <xsl:value-of select="UnitUnderTest"/> digital video system as part of the <xsl:value-of select="ProjectName"/> project. It provides the information required by the 'Demonstration and Acceptance Testing' section of the HD Digital Transport and Distribution System specification <a href="http://www.crestron.com/downloads/pdf/product_engineering_specifications/es_digitalmedia_hd_digital_transport_and_distribution_system.pdf">(HD-DTDS)</a>. The tests cover the EDID and HDCP subsystems to ensure they are configured correctly. In addition, the digital video system is tested to ensure that the cabling can support the required data rates. Any items that should be corrected will be reported in the "Open Items" section on page 3. Items that may be acceptable but are highlighted to bring them to your attention are reported in "Important Notices" on page 4. The EDID and HDCP system configuration and results of cable testing are detailed in tables on the pages that follow. The Demonstration and Acceptance Testing section of the HD-DTDS is included in Appendix B for reference. For more information on the HD-DTDS, go to www.crestron.com and navigate to the DigitalMedia Resources section.
	</td></tr>
    <tr><td class="disclaimer" colspan="2">

         <table class="coverpageleft"><tr><td>
        This report is for the exclusive use of <xsl:value-of select="Integrator/IntegratorName"/>'s client and its representatives - and is provided pursuant to the agreement between <xsl:value-of select="Integrator/IntegratorName"/> and its client. The observations and test results in this report are revelant only to the particular digital video system tested and only at the time of commissioning. This report must be generated by a DigitalMedia Certified Engineer (DMC-E) to be valid. 
                </td></tr></table>
	</td>
    </tr>
    <tr>
    <td width="60%">
        <br/>
            Commissioning Engineer:
        <br><br><br></br></br></br><br></br><br></br>
        <xsl:value-of select="Preparer/PreparerName"/><br></br>
        <xsl:value-of select="Preparer/PreparerTitle"/><br></br>
	</td>
    <td width="30%">
        <br><br><br></br></br></br><br></br><br></br><br/>
        <hr></hr>
        Date
	</td>
    </tr>
    <tr>
        <td width="60%">
            <br/>
            Reviewed and Approved:
        <br><br><br></br></br></br><br><br></br></br>
        <xsl:value-of select="Reviewer/ReviewerName"/><br></br>
        <xsl:value-of select="Reviewer/ReviewerTitle"/><br></br>
	</td>
    <td width="30%">
        <br><br><br></br></br></br><br></br><br></br><br></br>
        <hr></hr>
        Date
	</td>
    </tr>
    <tr>
        <td colspan="2">
            <div class="generaltext"><br></br><br></br><br></br><br/><br/><br/>
                <b><xsl:value-of select="Integrator/IntegratorName"/></b><br></br>
                <xsl:value-of select="Integrator/IntegratorAddress1"/><br></br>
                <xsl:value-of select="Integrator/IntegratorAddress2"/><br></br>
                <xsl:value-of select="Integrator/IntegratorPhone"/>
                    </div>
		</td>
	</tr>
    </Table>
        <br/><br/><br/>
</xsl:template>
  
	<xsl:template match="TestReports">

        <xsl:call-template name="Overview"/>
		<!-- removed: Bug 40811, 20100914
		<xsl:apply-templates select="HDCPComplianceOnSourceDevices"/>
		<xsl:apply-templates select="HDCPComplianceOnSourceDevices/Inputs"/>
		-->
		<h1> </h1>
		<h1> </h1>
		<hr></hr>
		<xsl:apply-templates select="VideoResolutionAndAudioFormatSupportOnOutputs" mode="All_Tables"/>
		<h1> </h1>
		<h1> </h1>
		<hr></hr>
    <xsl:apply-templates select="OutputCapabilities"/>
    <h1> </h1>
    <h1> </h1>
    <hr></hr>
  </xsl:template>

  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ============================================== "Overview" templates =================================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <!--xsl:template match="Overview"-->
    
  
    
  <xsl:template name="Overview">
    <br style="page-break-before:always;"/>
    <xsl:call-template name= "Overview_OpenItems" />
    <br/>
    <xsl:call-template name= "Overview_ImportantNotices" />
    <br/>


    <h2>Firmware and Serial Numbers</h2>

    <h3>DigitalMedia Switcher Chassis and Cards</h3>
		<xsl:call-template name="ConnectedDevices_ChassisAndCardsTable"/>

		<xsl:call-template name="RPSStatusTable"/>

		
	  <xsl:if test="$var_ShowTable_ConnectedDevices = 'TRUE'">
			<h3>DigitalMedia Connected Devices</h3>
			<xsl:call-template name="ConnectedDevices_ConnectedDevicesTable"/>
	  </xsl:if>
    <!--Cards reported in this table are installed in different chassis connected to this chassis.-->

    <xsl:if test="$var_ShowTable_LinkReport = 'TRUE'">
      <h3>Link Quality Data</h3>
		  <xsl:call-template name="LinkQualityTable"/>
    </xsl:if>  
 
	
  </xsl:template>

  <xsl:template name="Overview_OpenItems">
    <table class="overview">
      <tr>
        <th colspan="2">
          Open Items

          <div class="subtext">
            <br/><br/>There should not be any open items in a completed system that is signed-off. Any open items indicated in the table below shall be corrected before system sign-off is done.
          </div>
        </th>
      </tr>
      <!--tr>
        <th>
          <div class="overviewleftcolumn">HDCP:</div>
        </th>
        <td>
          <xsl:for-each select="HDCPComplianceOnSourceDevices/Inputs/Input">

          </xsl:for-each>
        </td>
      </tr-->
 
	<xsl:variable name="var_OverviewImportantEDID">
		<xsl:for-each select="OutputCapabilities/Outputs/Output">
			<xsl:choose>
				<xsl:when test="(Data/EDIDInfo/HotplugStatus='ON') and (Data/EDIDInfo/EDIDValid='Invalid')">T</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
				<xsl:otherwise>F</xsl:otherwise> <!-- MUST be in a single line to avoid extra spaces in the value -->
			</xsl:choose>
		</xsl:for-each>
	</xsl:variable>
  
	<xsl:if test="contains($var_OverviewImportantEDID, 'T')">
  
      <tr>
        <th>
          <div class="overviewleftcolumn">EDID:</div>
        </th>
        <td>
          <xsl:for-each select="OutputCapabilities/Outputs/Output">
            <xsl:if test="(Data/EDIDInfo/HotplugStatus='ON') and (Data/EDIDInfo/EDIDValid='Invalid')">
              [<xsl:value-of select="Number"/>]&#32;
              <xsl:value-of select="Name"/> - EDID cannot be read from sink. Check cabling and ensure sink device is on.
              <br/><br/>
            </xsl:if>
          </xsl:for-each>
        </td>
      </tr>

	</xsl:if>

	<xsl:variable name="var_OverviewImportantCabling">
		<xsl:for-each select="OutputCapabilities/Outputs/Output">
			<xsl:choose>
				<xsl:when test="Data/Cables/Cable/MeasurementStatus/text() = 'Invalid'">T</xsl:when><!-- MUST be in a single line to avoid extra spaces in the value -->
				<xsl:otherwise>F</xsl:otherwise> <!-- MUST be in a single line to avoid extra spaces in the value -->
			</xsl:choose>
		</xsl:for-each>
	</xsl:variable>
	  

	<xsl:if test="contains($var_OverviewImportantCabling, 'T')">
      <tr>
        <th>
          <div class="overviewleftcolumn">Cabling:</div>
        </th>
        <td>


          <xsl:for-each select="OutputCapabilities/Outputs/Output">

            <xsl:if test="Data/Cables/Cable/MeasurementStatus/text() = 'Invalid'">
              [<xsl:value-of select="Number"/>]&#32;
              <xsl:value-of select="Name"/> - Cable measurement failed.
              <br/><br/>
            </xsl:if>



          </xsl:for-each>


        </td>
      </tr>
	</xsl:if>

      <!--
                        <tr>
                      <th>
                              Firmware:
			              </th>
                      <td>
                          
                          
                      <xsl:for-each select="HDCPComplianceOnSourceDevices/Inputs/Input">
                          <xsl:variable name="fwName" select="FirmwareName"/>
                          <xsl:variable name="fwVer" select="FirmwareVersion"/>
                          <xsl:value-of select="FirmwareVersion"/>
                          <xsl:for-each select="/DigitalMediaTestReport/LatestPUF/IncludedDevices">
                              <xsl:if test="Data/Cables/Cable/MaxDataRate='0.00 Gbps'">
                              <xsl:value-of select="Name"/> - data rate check has not been performed.
                          
                              <br/><br/>
                          </xsl:if>
                              </xsl:for-each>
                              
		              </xsl:for-each>
                           
                         
		              </td>
                    </tr>
        -->
    </table>
  </xsl:template>

  <xsl:template name="Overview_ImportantNotices">
    <table class="overview">
      <tr>
        <th colspan="2">
          Important Notices
          <div class="subtext">
            <br/><br/>Notices are indications of items that may cause unexpected behavior. Each of these items shall be individually reviewed and approved by the sign-off engineer.<br/>
          </div>
        </th>
      </tr>
      
      <tr>
        <th>
          <div class="overviewleftcolumn">EDID:</div>
        </th>
        <td>
          <xsl:for-each select="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs/Inputs/Input">

            <xsl:if test="(count(Data/SupportedResolutions/Resolution) &lt; 4) and not(contains(FirmwareName, 'VID')) and not(contains(FirmwareName, 'SDI'))">
              [<xsl:value-of select="Number"/>]&#32;
              <xsl:value-of select="Name"/> input EDID supports fewer than three video timings. It is recommended that all EDIDs report at least 3 timings to ensure compatibility with sources.

              <br/><br/>
            </xsl:if>

          </xsl:for-each>


        </td>
      </tr>
      <!--tr>
          <th>
                  <div class="overviewleftcolumn">Cabling:</div>
			  </th>
          <td>
              <xsl:for-each select="OutputCapabilities/Outputs/Output">
              <xsl:if test="(Data/Cables/Cable/CableType!='DM') and (contains(FirmwareName, 'CATO-HD'))">
				  [<xsl:value-of select="Number"/>]&#32;
                  <xsl:value-of select="Name"/> - DigitalMedia cable not used, <xsl:value-of select="Data/Cables/Cable/CableType"/> cable used instead. 
              
                  <br/><br/>
              </xsl:if>
                  
              <xsl:if test="(Data/Cables/Cable/MaxDataRate!='6.75 Gbps') and (Data/Cables/Cable/MaxDataRate!='0.00 Gbps') and (contains(FirmwareName, 'CATO-HD'))">
				  [<xsl:value-of select="Number"/>]&#32;
                  <xsl:value-of select="Name"/> - output video cable has not been verified to pass 1080p Deep Color (6.75Gbps). Maximum verified data rate is <xsl:value-of select="Data/Cables/Cable/MaxDataRate"/>.
              
                  <br/><br/>
              </xsl:if>
                  
		  </xsl:for-each>
		  </td>
        </tr-->
      <tr>
        <th>
          <div class="overviewleftcolumn">Cabling:</div>
        </th>
        <td>


          <xsl:for-each select="OutputCapabilities/Outputs/Output">
            <!--xsl:if test="Data/Cables/Cable/MaxDataRate='0.00 Gbps'">
				  [<xsl:value-of select="Number"/>]&#32;
                  <xsl:value-of select="Name"/> - data rate check has not been performed.
              
                  <br/><br/>
              </xsl:if-->

            <xsl:if test="Data/Cables/Cable/MeasurementStatus/text() = 'Valid'">

              <xsl:if test="Data/Cables/Cable/LengthInMeters &lt; 10">
                [<xsl:value-of select="Number"/>]&#32;
                <xsl:value-of select="Name"/> - Cable length may be less than 5m (15'). Verify length.

                <br/><br/>
              </xsl:if>

              <xsl:if test="Data/Cables/Cable/LengthInMeters &gt; 45">
                [<xsl:value-of select="Number"/>]&#32;
                <xsl:value-of select="Name"/> - Cable length may be greater than 45m (150'). Verify length.

                <br/><br/>
              </xsl:if>
            </xsl:if>

            <!--xsl:if test="Data/Cables/Cable/MeasurementStatus/text() = 'Invalid'">
              [<xsl:value-of select="Number"/>]&#32;
              <xsl:value-of select="Name"/> - Cable measurement failed.
              <br/><br/>
            </xsl:if-->



          </xsl:for-each>


        </td>
      </tr>

    </table>
  </xsl:template>


  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ========================================= "ConnectedDevices" templates ============================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <xsl:template name="ConnectedDevices_ChassisAndCardsTable">
	<table class="resolutionsTable">
  		<xsl:call-template name="ConnectedDevices_ChassisAndCardsTable_Title"></xsl:call-template>
  		<xsl:call-template name="ConnectedDevices_ChassisAndCardsTable_Row_Chassis"></xsl:call-template>
  		<xsl:call-template name="ConnectedDevices_ChassisAndCardsTable_Row_InputCards"></xsl:call-template>
  		<xsl:call-template name="ConnectedDevices_ChassisAndCardsTable_Row_OutputCards"></xsl:call-template>
	</table>
  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="ConnectedDevices_ChassisAndCardsTable_Title">
	<tr>
		<th>Name</th>
		<th>Device</th>
		<th>Firmware Version</th>
		<th>Serial Number</th>
	</tr>
  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="ConnectedDevices_ChassisAndCardsTable_Row_Chassis">
    <tr>
      <td> [Chassis]</td>
      <td> <xsl:value-of select="/DigitalMediaTestReport/ProjectInfo/FirmwareName"/></td>
      <td> <xsl:value-of select="/DigitalMediaTestReport/ProjectInfo/FirmwareVersion"/></td>
      <td> <xsl:value-of select="/DigitalMediaTestReport/ProjectInfo/SerialNumber"/></td>
    </tr>
  </xsl:template>
  
  <!-- ======================================================================================================================= -->
  <xsl:template name="ConnectedDevices_ChassisAndCardsTable_Row_InputCards">
    <xsl:for-each select="/DigitalMediaTestReport/ConnectedDevices/InputCard">
      <tr>
		    <td>
				  <small>[Input <xsl:value-of select="SlotNumbers"/>] </small> 
                  <xsl:value-of select="DisplayNames"/>
		    </td>
        <td>
			<xsl:value-of select="FirmwareName"/>
        </td>
		<td>
          <xsl:value-of select="FirmwareVersion"/>
		</td>
		<td>
          <xsl:value-of select="SerialNumber"/>
		</td>
      </tr>
    </xsl:for-each>

  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="ConnectedDevices_ChassisAndCardsTable_Row_OutputCards">
    <xsl:for-each select="/DigitalMediaTestReport/ConnectedDevices/OutputCard">
      <!--xsl:if test="(Number mod 2 &gt; 0) and not(((substring-after(FirmwareName,'-Stream') = '-0') or (substring-after(FirmwareName,'-Stream') = '0' )) and (Type = 'HDMIOutput'))"-->
        <tr>
		    <td>
				<small>[Output <xsl:value-of select="SlotNumbers"/>] </small> 
					<xsl:value-of select="DisplayNames"/>
			</td>
			<td>
				<xsl:value-of select="FirmwareName"/>
			</td>
			<td>
				<xsl:value-of select="FirmwareVersion"/>
			</td>
			<td>
				<xsl:value-of select="SerialNumber"/>
			</td>
        </tr>
      <!--/xsl:if-->
    </xsl:for-each>
  </xsl:template>
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <xsl:template name="ConnectedDevices_ConnectedDevicesTable">
	<table class="resolutionsTable">
  		<xsl:call-template name="ConnectedDevices_ConnectedDevicesTable_Title"></xsl:call-template>
  		<xsl:call-template name="ConnectedDevices_ConnectedDevicesTable_Row_Devices"></xsl:call-template>
	</table>
  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="ConnectedDevices_ConnectedDevicesTable_Title">
	<tr>
		<th>Device</th>
		<th>Firmware Version</th>
		<th>Serial Number</th>
		<th>Connected to <small>(Slot Number)</small></th>
	</tr>
  </xsl:template>

  <xsl:template name="ConnectedDevices_ConnectedDevicesTable_Row_Devices">
    <xsl:for-each select="/DigitalMediaTestReport/ConnectedDevices/DeviceConnectedToInput">
      <tr>
		    <!--td>
				  <small>[Input <xsl:value-of select="SlotNumbers"/>] </small> 
                  <xsl:value-of select="DisplayNames"/>
		    </td-->
        <td>
			<xsl:value-of select="FirmwareName"/>
        </td>
		<td>
          <xsl:value-of select="FirmwareVersion"/>
		</td>
		<td>
          <xsl:value-of select="SerialNumber"/>
		</td>
		<td>
		  <small>[Input </small>
		  <small><xsl:value-of select="SlotNumbers"/></small>
		  <small>] </small> 
		  <xsl:value-of select="DisplayNames"/>
		</td>
      </tr>
    </xsl:for-each>

    <xsl:for-each select="/DigitalMediaTestReport/ConnectedDevices/DeviceConnectedToOutput">
      <tr>
		    <!--td>
				  <small>[Input <xsl:value-of select="SlotNumbers"/>] </small> 
                  <xsl:value-of select="DisplayNames"/>
		    </td-->
        <td>
			<xsl:value-of select="FirmwareName"/>
        </td>
		<td>
          <xsl:value-of select="FirmwareVersion"/>
		</td>
		<td>
          <xsl:value-of select="SerialNumber"/>
		</td>
		<td>
		  <small>[Output </small>
		  <small><xsl:value-of select="SlotNumbers"/></small>
		  <small>] </small> 
		  <xsl:value-of select="DisplayNames"/>
		</td>
      </tr>
    </xsl:for-each>
  </xsl:template>
  

  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ==================================== "HDCPComplianceOnSourceDevices" templates ======================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->
      <!--xsl:template match="HDCPComplianceOnSourceDevices/Inputs"-->
    
	<xsl:template match="HDCPComplianceOnSourceDevices">
		<h2>
			HDCP Configuration Matrix
		</h2>
		<p><div class="subtext">
			<xsl:value-of select="OverviewText"/>
            </div>
		</p>
	</xsl:template>

    
    
  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ================================ "HDCPComplianceOnSourceDevices/Inputs" templates ===================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <!--xsl:template match="HDCPComplianceOnSourceDevices/Inputs"-->
  <xsl:template match="HDCPComplianceOnSourceDevices/Inputs">
			<table class="resolutionsTable">
		  <tr>
			<th>Name</th>
            <th>Card Type</th>
			<th># of KSVs<br/>Supported</th>

		  </tr>
		  <xsl:for-each select="Input">
			<tr>

			  <td>
				<small>[<xsl:value-of select="Number"/>] </small> 
                <xsl:value-of select="Name"/>
			  </td>
                <td>

                  <xsl:choose>
                    <xsl:when test="contains(FirmwareName,'-Stream')">
                      <xsl:value-of select="substring-before(FirmwareName,'-Stream')"/>
                    </xsl:when>
                    <xsl:otherwise>
                        <xsl:value-of select="FirmwareName"/>
                    </xsl:otherwise>
                  </xsl:choose>

				</td>
			  <xsl:choose>
				<xsl:when test="Data/HDCPState = 'HDCP not required'">
					  <xsl:choose>
						<xsl:when test="Data/MaxDevices &lt; Data/DownstreamDevices">
						  <td  bgcolor="#FFAAAA">
							<xsl:value-of select="Data/MaxDevices"/>
						  </td>
						</xsl:when>
						<xsl:otherwise>
						  <td>
							<xsl:value-of select="Data/MaxDevices"/>
						  </td>
						</xsl:otherwise>
					  </xsl:choose>
				</xsl:when>
				<xsl:otherwise>
				
					<xsl:choose>
						<xsl:when test="Data/KSVLimitTestStatus = 'HDCP check completed successfully'">
								  <xsl:choose>
									<xsl:when test="Data/MaxDevices &lt; Data/DownstreamDevices">
									  <td>
										<div class="highlight"><xsl:value-of select="Data/MaxDevices"/></div>
									  </td>
									</xsl:when>
									<xsl:otherwise>
									  <td>
										<xsl:value-of select="Data/MaxDevices"/>
									  </td>
									</xsl:otherwise>
								  </xsl:choose>
						</xsl:when>
						<xsl:when test="Data/KSVLimitTestStatus = 'No HDCP check needed'">
								  <xsl:choose>
									<xsl:when test="Data/MaxDevices &lt; Data/DownstreamDevices">
									  <td  bgcolor="#FFAAAA">
										<xsl:value-of select="Data/MaxDevices"/>
									  </td>
									</xsl:when>
									<xsl:otherwise>
									  <td>
										<xsl:value-of select="Data/MaxDevices"/>
									  </td>
									</xsl:otherwise>
								  </xsl:choose>
						</xsl:when>
						<xsl:when test="Data/KSVLimitTestStatus = 'Non-HDCP source'">
								  <xsl:choose>
									<xsl:when test="Data/MaxDevices &lt; Data/DownstreamDevices">
									  <td  bgcolor="#FFAAAA">
										<xsl:value-of select="Data/MaxDevices"/>
									  </td>
									</xsl:when>
									<xsl:otherwise>
									  <td>
										<xsl:value-of select="Data/MaxDevices"/>
									  </td>
									</xsl:otherwise>
								  </xsl:choose>
						</xsl:when>
						<xsl:otherwise>
							<xsl:choose>
								<xsl:when test="Data/KSVLimitTestStatus = 'HDCP check not run'">
								  <td bgcolor="#FFFF00">Not Tested</td>
								</xsl:when>
								<xsl:when test="Data/KSVLimitTestStatus = 'No video source'">
								  <td bgcolor="#FFFF00">Not Tested</td>
								</xsl:when>
								<xsl:when test="Data/KSVLimitTestStatus = 'Source device uses incompatible HDCP'">
								  <td bgcolor="#FFFF00">Not Tested</td>
								</xsl:when>
								<xsl:when test="Data/KSVLimitTestStatus = 'HDCP check Failed'">
								  <td bgcolor="#FFFF00">Not Tested</td>
								</xsl:when>
								<xsl:when test="Data/KSVLimitTestStatus = 'Not Reported'">
								  <td bgcolor="#FFFF00">16</td>
								</xsl:when>
								<xsl:otherwise>
								  <td bgcolor="#FFFF00"> - </td>
								</xsl:otherwise>
							</xsl:choose>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:otherwise>
			  </xsl:choose>

			</tr>
		  </xsl:for-each>
		</table>

		<p><div class="subtext">
			Note that DM input cards may not be tested - this is OK, the transmitter will test the source.
            </div>
			</p>
	</xsl:template>



  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ============================== "VideoResolutionAndAudioFormatSupportOnOutputs" templates ============================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <!--xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs" mode="All_Tables"-->
  <xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs" mode="All_Tables">
    <h2>
      Video Timings on Input EDIDs
    </h2>
    <p><div class="subtext">
      This table shows the Extended Display Identification Data (EDID) for video timings that is present on each input. This data is important to know because many sources, particularly computers will not output video in any resolution except those found in the EDID.
        </div>
    </p>
    <xsl:apply-templates select="../VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByInputs_Table" />
	
    <p><div class="subtext">
      '<xsl:value-of select="$var_Table_PreferredMark_Symbol"/>' means 'Preferred Resolution'.
        </div>
    </p>
	
    <h2>
      Video Timings Detected on Output EDIDs
    </h2>
    <p><div class="subtext">
      This table shows the Extended Display Identification Data (EDID) reported by each device connected to the HDMI outputs of the DigitalMedia system. These are indications from the connected devices of what video formats they support. The device may support additional formats beyond what is indicated in the EDID.
        </div>
    </p>

    <xsl:apply-templates select="../VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByOutputs_Table" />
    <p><div class="subtext">
      'Not connected' means that we have detected that hotplug is low. A device connected to this output may be off or switched to another input.
        </div>
    </p>
    <p><div class="subtext">
      '<xsl:value-of select="$var_Table_PreferredMark_Symbol"/>' means 'Preferred Resolution'.
        </div>
    </p>
	
	<xsl:if test="$var_ShowTable_VideoTimingAndAudioOnLoopOutputs = 'TRUE'">
		<h2>
		  Video Timings Detected on Loop Out EDIDs
		</h2>
		<p><div class="subtext">
		  This table shows the Extended Display Identification Data (EDID) reported by each device connected to the HDMI loop outputs on each input card in the DigitalMedia system. These are indications from the connected devices of what video formats they support. The device may support additional formats beyond what is indicated in the EDID.
			</div>
		</p>

		<xsl:apply-templates select="../VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByLocalOutputs_Table" />
		 <p>
			<div class="subtext">
		  'Not connected' means that we have detected that hotplug is low. A device connected to this output may be off or switched to another input.
			</div>
		 </p>
    <p><div class="subtext">
      '<xsl:value-of select="$var_Table_PreferredMark_Symbol"/>' means 'Preferred Resolution'.
        </div>
    </p>
	</xsl:if>
	
 
    <h2>
      Audio Formats on Input EDIDs
    </h2>
    <p><div class="subtext">
      This table shows the Extended Display Identification Data (EDID) information for audio formats that is present on each input. This data is important to know because many sources will only output audio formats indicated in the EDID. Input cards that contain DSPs (-DSP versions) will automatically create a 2-channel downmix of incoming multi-channel audio and route that to destinations that only support 2-channel audio.
        </div>
    </p>

    <xsl:apply-templates select="../VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="AudioFormatsSupportedByInputs_Table" />
    <h2>
      Audio Formats Detected on Output EDIDs
    </h2>
    <p><div class="subtext">
      This table shows the Extended Display Identification Data (EDID) information regarding audio formats reported by each device connected to the HDMI outputs of the DigitalMedia system. These are indications from the connected devices of what audio formats they support. 
        </div>
    </p>

    <xsl:apply-templates select="../VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="AudioFormatsSupportedByOutputs_Table" />
    <p><div class="subtext">
      'Not connected' means that we have detected that hotplug is low. A device connected to this output may be off or switched to another input.
        </div>
    </p>
    
	<xsl:if test="$var_ShowTable_VideoTimingAndAudioOnLoopOutputs = 'TRUE'">
		
		<h2>
		  Audio Formats Detected on HDMI Loop out EDIDs
		</h2>
		<p><div class="subtext">
		  This table shows the Extended Display Identification Data (EDID) information regarding audio formats reported by each device connected to the HDMI loop outputs of the input cards on the DigitalMedia system. These are indications from the connected devices of what audio formats they support. 
			</div>
		</p>

		<xsl:apply-templates select="../VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="AudioFormatsSupportedByLocalOutputs_Table" />
		<p><div class="subtext">
		  'Not connected' means that we have detected that hotplug is low. A device connected to this output may be off or switched to another input.
			</div>
		</p>
		
	</xsl:if>
	
	
	
  </xsl:template>


  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ========= "VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" templates =================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <!-- template match="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByInputs_Table"-->
  <xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByInputs_Table">

    <table class="resolutionsTable">
      <tr>
        <th>
          Video Resolutions<br/> Supported by Inputs
        </th><th></th>
    		<th valign="top" border="1">
        <div class="verticalResolution">HDMI 3D Support</div></th>
        <xsl:apply-templates select="ResolutionTable/Resolution" mode="VideoResolution_TableHeader" />
      </tr>
      <tr><xsl:apply-templates select="Inputs/Input" mode="VideoResolution_TableRow" /></tr>

    </table>

  </xsl:template>

  <!-- template match="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByOutputs_Table"-->
  <xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByOutputs_Table">

    <table class="resolutionsTable">
      <tr>
        <th>
          Video Resolutions<br/> Supported by Outputs
        </th>
        <th></th>
    		<th valign="top" border="1">
        <div class="verticalResolution">HDMI 3D Support</div></th>
        <xsl:apply-templates select="ResolutionTable/Resolution" mode="VideoResolution_TableHeader" />
      </tr>
      <tr>
        <xsl:apply-templates select="Outputs/Output" mode="VideoResolution_TableRow" />
      </tr>

    </table>

  </xsl:template>

  <!-- template match="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByLocalOutputs_Table"-->
  <xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByLocalOutputs_Table">

    <table class="resolutionsTable">
      <tr>
        <th>
          Video Resolutions<br/> Supported by Loop<br/>Outputs
        </th>
        <th></th>
    		<th valign="top" border="1">
        <div class="verticalResolution">HDMI 3D Support</div></th>
        <xsl:apply-templates select="ResolutionTable/Resolution" mode="VideoResolution_TableHeader" />
      </tr>
      <tr>
        <xsl:apply-templates select="Outputs/Input" mode="VideoResolution_TableRow" />
      </tr>

    </table>

  </xsl:template>


  <xsl:template match="ResolutionTable/Resolution" mode="VideoResolution_TableHeader">
    <th valign="top" border="1">
        <div class="verticalResolution">
      <!-- <small>[<xsl:value-of select="Index/text()" />]</small> -->
      &#32; &#32;
      <xsl:value-of select="HActiveSizePixels/text()"/>
      x<xsl:value-of select="VActiveSizePixels/text()"/>
      <xsl:choose>
        <xsl:when test="contains(Name/text(), 'Reduced Blanking')">(rb)@</xsl:when>
        <xsl:otherwise>
          <xsl:choose>
            <xsl:when test="contains(Name/text(), 'p')">p</xsl:when>
            <xsl:when test="contains(Name/text(), 'i')">i</xsl:when>
            <xsl:otherwise>@</xsl:otherwise>
          </xsl:choose>
        </xsl:otherwise>
      </xsl:choose>
      <xsl:value-of select="RefreshRateHz/text()"/>
            </div>
    </th>
  </xsl:template>

  <xsl:template match="ResolutionTable/Resolution" mode="VideoResolution_TableRow">
    <xsl:param name="SupportedVideoResolution_index" />
    <xsl:param name="PreferredVideoResolution_index" />
    <xsl:choose>
      <xsl:when test="Index/text() = $SupportedVideoResolution_index">
	  
		<xsl:choose>
		  <xsl:when test="Index/text() = $PreferredVideoResolution_index">
			<td align="center" style="font-size:10px;color:{$var_Table_PreferredMark_Color}; background-color:{$var_Table_PreferredMark_BackgroundColor}">
			  <b><xsl:value-of select="$var_Table_PreferredMark_Symbol"/></b>
			</td>
		  </xsl:when>
	  
			<xsl:otherwise>
				<!--<td><span style="font-family:Wingdings;font-size:20px;color:green">&#252;</span></td>-->
				<td align="center" style="font-size:8px;color:{$var_Table_CheckMark_Color}; background-color:{$var_Table_CheckMark_BackgroundColor}">
				<b><xsl:value-of select="$var_Table_CheckMark_Symbol"/></b></td>
			</xsl:otherwise> 
		</xsl:choose>
		  
		  
      </xsl:when>
      <xsl:otherwise>
       
        <td align="center" style="font-size:6px;color:white">_</td>
      </xsl:otherwise> 
    </xsl:choose>
  </xsl:template>


  <xsl:template match="Inputs/Input" mode="VideoResolution_TableRow">
    <tr>
      <td style="white-space:nowrap;">
        <small>
          [<xsl:value-of select="Number"/>]
        </small>
        
          <xsl:value-of select="Name"/>
        
      </td>
      <td></td>
 
	<xsl:choose>
    <xsl:when test="contains(FirmwareName, 'VID')">
        <td colspan="36"><small>EDID not used on analog video inputs</small></td>
	  </xsl:when>
	<xsl:when test="contains(FirmwareName, 'SDI')">
	<td colspan="36"><small>EDID not used on SDI video input</small></td>
	  </xsl:when>
	  <xsl:otherwise>


		<xsl:choose>

			<xsl:when test="contains(Data/EDID3DCapability,'INVALID')">
				<td align="center" style="font-size:6px;color:white">_</td>
			</xsl:when>
			<xsl:when test="contains(Data/EDID3DCapability,'3D Support: None')">
				<td align="center" style="font-size:6px;color:white">_</td>
			</xsl:when>
			<xsl:when test="contains(Data/EDID3DCapability,'3D Support: Basic')">
				<td align="center" style="font-size:8px;color:{$var_Table_CheckMark_Color}; background-color:{$var_Table_CheckMark_BackgroundColor}">
          <b><xsl:value-of select="$var_Table_CheckMark_Symbol"/></b></td>
			</xsl:when>
			<xsl:otherwise>
				<td align="center" style="font-size:6px;color:white">_</td>


			</xsl:otherwise>

		</xsl:choose>















    		<xsl:apply-templates select="Data" mode="VideoResolution_TableRowCell"/>
	  </xsl:otherwise>

	</xsl:choose>

    </tr>
  </xsl:template>

  <xsl:template match="Outputs/Input" mode="VideoResolution_TableRow">
    <tr>
      <td style="white-space:nowrap;">
        <small>
          [<xsl:value-of select="Number"/>]
        </small>
        
          <xsl:value-of select="Name"/>
      
        &#32;
        <xsl:choose>
          <xsl:when test="Type/text() = 'InputLocalHDMIOutput'"></xsl:when>
          <xsl:when test="Type/text() = 'DMOutput'"> (DM)</xsl:when>
          <xsl:when test="Type/text() = 'HDMIOutput'"> (HDMI)</xsl:when>
          <xsl:otherwise>
          </xsl:otherwise>
        </xsl:choose>
      </td>
      <td></td>


      <xsl:choose>
        <xsl:when test="contains(FirmwareName, 'VID')">
          <td colspan="36">
            <small>EDID not available on analog video inputs</small>
          </td>
        </xsl:when>
        <xsl:when test="contains(FirmwareName, 'SDI')">
          <td colspan="36">
            <small>EDID not available on SDI inputs</small>
          </td>
        </xsl:when>
        <xsl:otherwise>

            <xsl:variable name="var_EDIDValid">
        <xsl:call-template name="CheckEDIDValidStatus">
          <xsl:with-param name="param_validation_list_path" select="/DigitalMediaTestReport/TestReports/OutputCapabilities/Outputs/Input" />
        </xsl:call-template>
      </xsl:variable>

            <xsl:variable name="outputs-count" select="count(/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs/ResolutionTable/Resolution)"/>


            <xsl:choose>
              <xsl:when test="$var_EDIDValid = '(VALID)'">
				      <xsl:choose>

			      <xsl:when test="contains(Data/EDID3DCapability,'INVALID')">
				      <td align="center" style="font-size:6px;color:white">_</td>
			      </xsl:when>
			      <xsl:when test="contains(Data/EDID3DCapability,'3D Support: None')">
				      <td align="center" style="font-size:6px;color:white">_</td>
			      </xsl:when>
			      <xsl:when test="contains(Data/EDID3DCapability,'3D Support: Basic')">
				      <td align="center" style="font-size:8px;color:{$var_Table_CheckMark_Color}; background-color:{$var_Table_CheckMark_BackgroundColor}">
                <b><xsl:value-of select="$var_Table_CheckMark_Symbol"/></b></td>
			      </xsl:when>
			      <xsl:otherwise>
				      <td align="center" style="font-size:6px;color:white">_</td>


			      </xsl:otherwise>

		      </xsl:choose>
                    <xsl:apply-templates select="Data" mode="VideoResolution_TableRowCell"/>
              </xsl:when>

              <xsl:otherwise>


                <td colspan="36">


                  <small>
                    <xsl:value-of select="$var_EDIDValid"/>
                  </small>
                  <!--{EDID Invalid}-->
                </td>
              </xsl:otherwise>
            </xsl:choose>

        </xsl:otherwise>
      </xsl:choose>

    </tr>
  </xsl:template>



  <xsl:template match="Outputs/Output" mode="VideoResolution_TableRow">
    <tr>
      <td style="white-space:nowrap;">
        <small>
          [<xsl:value-of select="Number"/>
          <xsl:choose>
            <xsl:when test="Type/text() = 'DMOutput'">a-DM</xsl:when>
            <xsl:when test="Type/text() = 'HDMIOutput'">b-HDMI</xsl:when>
            <xsl:otherwise>
            </xsl:otherwise>
          </xsl:choose>]
        </small>
        
          <xsl:value-of select="Name"/>

        &#32;

      </td>
      <td></td>


      <xsl:variable name="var_EDIDValid">
        <xsl:call-template name="CheckEDIDValidStatus">
          <xsl:with-param name="param_validation_list_path" select="/DigitalMediaTestReport/TestReports/OutputCapabilities/Outputs/Output" />
        </xsl:call-template>
      </xsl:variable>

      <xsl:variable name="outputs-count" select="count(/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs/ResolutionTable/Resolution)"/>


      <xsl:choose>
        <xsl:when test="$var_EDIDValid = '(VALID)'">
		<xsl:choose>

			<xsl:when test="contains(Data/EDID3DCapability,'INVALID')">
				<td align="center" style="font-size:6px;color:white">_</td>
			</xsl:when>
			<xsl:when test="contains(Data/EDID3DCapability,'3D Support: None')">
				<td align="center" style="font-size:6px;color:white">_</td>
			</xsl:when>
			<xsl:when test="contains(Data/EDID3DCapability,'3D Support: Basic')">
				<td align="center" style="font-size:8px;color:{$var_Table_CheckMark_Color}; background-color:{$var_Table_CheckMark_BackgroundColor}">
          <b><xsl:value-of select="$var_Table_CheckMark_Symbol"/></b></td>
			</xsl:when>
			<xsl:otherwise>
				<td align="center" style="font-size:6px;color:white">_</td>


			</xsl:otherwise>

		</xsl:choose>
              <xsl:apply-templates select="Data" mode="VideoResolution_TableRowCell"/>
        </xsl:when>
        <xsl:otherwise>


          <td colspan="36">


            <small>
              <xsl:value-of select="$var_EDIDValid"/>
            </small>
            <!--{EDID Invalid}-->
          </td>
        </xsl:otherwise>
      </xsl:choose>


    </tr>
  </xsl:template>


  <xsl:template match="Inputs/Input/Data" mode="VideoResolution_TableRowCell">
    <xsl:variable name="SupportedVideoResolution_index" select="SupportedResolutions/Resolution/@Index" /> 
    <xsl:variable name="PreferredVideoResolution_index" select="SupportedResolutions/Resolution[1]/@Index" /> 
    <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs/ResolutionTable/Resolution" mode="VideoResolution_TableRow">
      <xsl:with-param name="SupportedVideoResolution_index" select="$SupportedVideoResolution_index" />
      <xsl:with-param name="PreferredVideoResolution_index" select="$PreferredVideoResolution_index" />
    </xsl:apply-templates>
  </xsl:template>

  <xsl:template match="Outputs/Input/Data" mode="VideoResolution_TableRowCell">
    <xsl:variable name="SupportedVideoResolution_index" select="SupportedResolutions/Resolution/@Index" />
    <xsl:variable name="PreferredVideoResolution_index" select="SupportedResolutions/Resolution[1]/@Index" /> 
    <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs/ResolutionTable/Resolution" mode="VideoResolution_TableRow">
      <xsl:with-param name="SupportedVideoResolution_index" select="$SupportedVideoResolution_index" />
      <xsl:with-param name="PreferredVideoResolution_index" select="$PreferredVideoResolution_index" />
    </xsl:apply-templates>
  </xsl:template>

  <xsl:template match="Outputs/Output/Data" mode="VideoResolution_TableRowCell">
    <xsl:variable name="SupportedVideoResolution_index" select="SupportedResolutions/Resolution/@Index" />
    <xsl:variable name="PreferredVideoResolution_index" select="SupportedResolutions/Resolution[1]/@Index" /> 
    <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs/ResolutionTable/Resolution" mode="VideoResolution_TableRow">
      <xsl:with-param name="SupportedVideoResolution_index" select="$SupportedVideoResolution_index" />
      <xsl:with-param name="PreferredVideoResolution_index" select="$PreferredVideoResolution_index" />
    </xsl:apply-templates>
  </xsl:template>


  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ========= "VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" templates ======================= -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <!-- template match="VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="VideoResolutionsSupportedByInputs_Table"-->
  <xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="AudioFormatsSupportedByInputs_Table">

    <xsl:variable name="var_audio_modes">
      <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs/Inputs" mode="get-modes-list-Inputs-Input" />
    </xsl:variable>

    <table class="resolutionsTable">
      <tr>
        <th>
          Audio Formats<br/> Supported by Inputs<br/>(Max sampling rate for<br/>each format shown in kHz)
        </th>
        <th></th>
        <xsl:call-template name="show-modes-list-Inputs-Input">
          <xsl:with-param name="modes" select="$var_audio_modes" />
          <xsl:with-param name="path" select="/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs"/><!--"/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs/Inputs" /-->
        </xsl:call-template>
      </tr>

      <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs/Inputs/Input" mode="AudioFormat_TableRow">
        <xsl:sort select="Number/text()" data-type="text" order="ascending" />
        <xsl:with-param name="modes" select="$var_audio_modes" />
      </xsl:apply-templates>
      
    </table>

  </xsl:template>


  <!-- template match="VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs" mode="VideoResolutionsSupportedByOutputs_Table"-->
  <xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="AudioFormatsSupportedByOutputs_Table">

    <xsl:variable name="var_audio_modes">
      <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs/Outputs" mode="get-modes-list-Outputs-Output" />
    </xsl:variable>

    <table class="resolutionsTable">
      <tr>
        <th>
          Audio Formats<br/> Supported by Outputs<br/>(Max sampling rate for<br/>each format shown in kHz)
        </th>
        <th></th>
        <xsl:call-template name="show-modes-list-Outputs-Output">
          <xsl:with-param name="modes" select="$var_audio_modes" />
        </xsl:call-template>
      </tr>

      <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs/Outputs/Output" mode="AudioFormat_TableRow">
        <xsl:sort select="Number/text()" data-type="text" order="ascending" />
        <xsl:with-param name="modes" select="$var_audio_modes" />
      </xsl:apply-templates>
      
    </table>

  </xsl:template>


  <!--xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="AudioFormatsSupportedByLocalOutputs_Table"-->
  <xsl:template match="VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs" mode="AudioFormatsSupportedByLocalOutputs_Table">

    <xsl:variable name="var_audio_modes">
      <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs/Outputs" mode="get-modes-list-Outputs-Input" />
    </xsl:variable>

    <table class="resolutionsTable">
      <tr>
        <th>
          Audio Formats<br/> Supported by Loop Outputs<br/>(Max sampling rate for<br/>each format shown in kHz)
        </th>
        <th></th>
        <xsl:call-template name="show-modes-list-Outputs-Input">
          <xsl:with-param name="modes" select="$var_audio_modes" />
        </xsl:call-template>
      </tr>
      
      <tr>
      </tr>


      <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/AudioFormatSupportOnOutputs/Outputs/Input" mode="AudioFormat_TableRow">
        <xsl:sort select="Number/text()" data-type="text" order="ascending" />
        <xsl:with-param name="modes" select="$var_audio_modes" />
      </xsl:apply-templates>
          
    </table>

  </xsl:template>



  <!--xsl:template match="Inputs" mode="get-modes-list-Inputs-Input"-->
  <xsl:template match="Inputs" mode="get-modes-list-Inputs-Input">
    <xsl:call-template name="FilterUniqueSequence">
      <xsl:with-param name="to_filter">
        <xsl:for-each select="Input/Data/SupportedAudioFormats/AudioFormat">
          <xsl:sort select="concat(Format/text(), ' ', Channels/text())" order="ascending" />
          <xsl:if test="position() > 1">,</xsl:if>
          <xsl:value-of select="concat(Format/text(), ' ', Channels/text())" /> 
            <!--<xsl:value-of select="concat(Format/text(), ' ', Channels/text())" /> -->
        </xsl:for-each>
      </xsl:with-param>
    </xsl:call-template>
  </xsl:template>

  <!--xsl:template match="Outputs" mode="get-modes-list-Outputs-Output"-->
  <xsl:template match="Outputs" mode="get-modes-list-Outputs-Output">
    <xsl:call-template name="FilterUniqueSequence">
      <xsl:with-param name="to_filter">
        <xsl:for-each select="Output/Data/SupportedAudioFormats/AudioFormat">
          <xsl:sort select="concat(Format/text(), ' ', Channels/text())" order="ascending" />
          <xsl:if test="position() > 1">,</xsl:if>
          <xsl:value-of select="concat(Format/text(), ' ', Channels/text())" />
        </xsl:for-each>
      </xsl:with-param>
    </xsl:call-template>
  </xsl:template>


  <!--xsl:template match="Outputs" mode="get-modes-list-Outputs-Input"-->
  <xsl:template match="Outputs" mode="get-modes-list-Outputs-Input">
    <xsl:call-template name="FilterUniqueSequence">
      <xsl:with-param name="to_filter">
        <xsl:for-each select="Input/Data/SupportedAudioFormats/AudioFormat">
          <xsl:sort select="concat(Format/text(), ' ', Channels/text())" order="ascending" />
          <xsl:if test="position() > 1">,</xsl:if>
          <xsl:value-of select="concat(Format/text(), ' ', Channels/text())" />
        </xsl:for-each>
      </xsl:with-param>
    </xsl:call-template>
  </xsl:template>


  <!--xsl:template name="show-modes-list-Inputs-Input"-->
  <xsl:template name="show-modes-list-Inputs-Input">
    <xsl:param name="modes" />

    <xsl:variable name="var_show_modes_list_header_style">writing-mode:tb-rl;filter: flipv fliph;white-space:nowrap;text-align:left;</xsl:variable>

    <xsl:choose>
      <xsl:when test="contains($modes, ',')">
        <xsl:variable name="mode" select="substring-before($modes, ',')" />
        <th style="{$var_show_modes_list_header_style}">
          <xsl:value-of select="$mode" />
          <br/>
          <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs/Inputs" mode="get-freq-list-Inputs-Input">
            <xsl:with-param name="mode" select="$mode" />
          </xsl:apply-templates>
        </th>
        <xsl:variable name="other-modes" select="substring-after($modes, ',')" />
        <xsl:if test="$other-modes != ''">
          <xsl:call-template name="show-modes-list-Inputs-Input">
            <xsl:with-param name="modes" select="$other-modes" />
          </xsl:call-template>
        </xsl:if>
      </xsl:when>
      <xsl:otherwise>
          <th style="{$var_show_modes_list_header_style}"> 
          <xsl:value-of select="$modes" />
          <br/>
            <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs/Inputs" mode="get-freq-list-Inputs-Input">
            <xsl:with-param name="mode" select="$modes" />
          </xsl:apply-templates>
        </th>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  
  <!--xsl:template name="show-modes-list-Outputs-Output"-->
  <xsl:template name="show-modes-list-Outputs-Output">
    <xsl:param name="modes" />

    <xsl:variable name="var_show_modes_list_header_style">writing-mode:tb-rl;filter: flipv fliph;white-space:nowrap;text-align:left;</xsl:variable>

    <xsl:choose>
      <xsl:when test="contains($modes, ',')">
        <xsl:variable name="mode" select="substring-before($modes, ',')" />
        <th style="{$var_show_modes_list_header_style}">
          <xsl:value-of select="$mode" />
          <br/>
          <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs/Outputs" mode="get-freq-list-Outputs-Output">
            <xsl:with-param name="mode" select="$mode" />
          </xsl:apply-templates>
        </th>
        <xsl:variable name="other-modes" select="substring-after($modes, ',')" />
        <xsl:if test="$other-modes != ''">
          <xsl:call-template name="show-modes-list-Outputs-Input">
            <xsl:with-param name="modes" select="$other-modes" />
          </xsl:call-template>
        </xsl:if>
      </xsl:when>
      <xsl:otherwise>
        <th style="{$var_show_modes_list_header_style}">
          <xsl:value-of select="$modes" />
          <br/>
          <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs/Outputs" mode="get-freq-list-Outputs-Output">
            <xsl:with-param name="mode" select="$modes" />
          </xsl:apply-templates>
        </th>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>


  <!--xsl:template name="show-modes-list-Outputs-Input"-->
  <xsl:template name="show-modes-list-Outputs-Input">
    <xsl:param name="modes" />

    <xsl:variable name="var_show_modes_list_header_style">writing-mode:tb-rl;filter: flipv fliph;white-space:nowrap;text-align:left;</xsl:variable>

    <xsl:choose>
      <xsl:when test="contains($modes, ',')">
        <xsl:variable name="mode" select="substring-before($modes, ',')" />
        <th style="{$var_show_modes_list_header_style}">
          <xsl:value-of select="$mode" />
          <br/>
          <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs/Outputs" mode="get-freq-list-Outputs-Input">
            <xsl:with-param name="mode" select="$mode" />
          </xsl:apply-templates>
        </th>
        <xsl:variable name="other-modes" select="substring-after($modes, ',')" />
        <xsl:if test="$other-modes != ''">
          <xsl:call-template name="show-modes-list-Outputs-Input">
            <xsl:with-param name="modes" select="$other-modes" />
          </xsl:call-template>
        </xsl:if>
      </xsl:when>
      <xsl:otherwise>
        <th style="{$var_show_modes_list_header_style}">
          <xsl:value-of select="$modes" />
          <br/>
          <xsl:apply-templates select="/DigitalMediaTestReport/TestReports/AudioFormatSupportOnOutputs/Outputs" mode="get-freq-list-Outputs-Input">
            <xsl:with-param name="mode" select="$modes" />
          </xsl:apply-templates>
        </th>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>


  <!--xsl:template match="Inputs/Input" mode="AudioFormat_TableRow"-->
  <xsl:template match="Inputs/Input" mode="AudioFormat_TableRow">
    <xsl:param name="modes" />
    <tr>
      <td style="white-space:nowrap;">
        <small>
          [<xsl:value-of select="Number"/>]
        </small>
        
          <xsl:value-of select="Name"/>
        
        <small>
          <xsl:choose>
            <xsl:when test="contains(FirmwareName,'-Stream')">
              (<xsl:value-of select="substring-before(FirmwareName,'-Stream')"/>)
            </xsl:when>
            <xsl:otherwise>
              (<xsl:value-of select="FirmwareName"/>)
            </xsl:otherwise>
          </xsl:choose>
        </small>

      </td>

      <td></td>


	<xsl:choose>
	<xsl:when test="contains(FirmwareName, 'VID')">
	<td colspan="36"><small>EDID not used on analog video inputs</small></td>
	  </xsl:when>
	<xsl:when test="contains(FirmwareName, 'SDI')">
	<td colspan="36"><small>EDID not used on SDI video input</small></td>
	  </xsl:when>
	  <xsl:otherwise>
    	      <xsl:apply-templates select="." mode="AudioFormat_TableRowCell">
        <xsl:with-param name="modes" select="$modes" />
      </xsl:apply-templates>
	  </xsl:otherwise>

	</xsl:choose>

    </tr>
  </xsl:template>


  <!--xsl:template match="Inputs/Input" mode="AudioFormat_TableRowCell"-->
  <xsl:template match="Inputs/Input" mode="AudioFormat_TableRowCell">
    <xsl:param name="modes" />
    <xsl:variable name="mode">
      <xsl:choose>
        <xsl:when test="contains($modes, ',')">
          <xsl:value-of select="substring-before($modes, ',')" />
        </xsl:when>
        <xsl:otherwise>
          <xsl:value-of select="$modes" />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:variable>
    <td style="text-align:center;">
      <xsl:choose>
        <xsl:when test="Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode][1]">
          <xsl:apply-templates select="Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode][1]" mode="max-freq" />
        </xsl:when>
        <xsl:otherwise>
          -
        </xsl:otherwise>
      </xsl:choose>
    </td>
    <xsl:if test="contains($modes, ',')">
      <xsl:apply-templates select="." mode="AudioFormat_TableRowCell">
        <xsl:with-param name="modes" select="substring-after($modes, ',')" />
      </xsl:apply-templates>
    </xsl:if>
  </xsl:template>

  <!--xsl:template match="Outputs/Output" mode="AudioFormat_TableRowCell"-->
  <xsl:template match="Outputs/Output" mode="AudioFormat_TableRowCell">
    <xsl:param name="modes" />

    <xsl:variable name="var_EDIDValid">
      <xsl:call-template name="CheckEDIDValidStatus">
        <xsl:with-param name="param_validation_list_path" select="/DigitalMediaTestReport/TestReports/OutputCapabilities/Outputs/Output" />
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="outputs-count" select="number(1)"/> <!-- TODO TO DO: count(tokenize($modes, ','))-->

    <xsl:choose>
      <xsl:when test="$var_EDIDValid = '(VALID)'">

        <xsl:variable name="mode">
            <xsl:choose>
              <xsl:when test="contains($modes, ',')">
                <xsl:value-of select="substring-before($modes, ',')" />
              </xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="$modes" />
              </xsl:otherwise>
            </xsl:choose>
          </xsl:variable>
          <td style="text-align:center;">
            <xsl:choose>
              <xsl:when test="Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode][1]">
                <xsl:apply-templates select="Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode][1]" mode="max-freq" />
              </xsl:when>
              <xsl:otherwise>
                -
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <xsl:if test="contains($modes, ',')">
            <xsl:apply-templates select="." mode="AudioFormat_TableRowCell">
              <xsl:with-param name="modes" select="substring-after($modes, ',')" />
            </xsl:apply-templates>
          </xsl:if>

      </xsl:when>
      <xsl:otherwise>
        <td colspan="12">
          <small>
            <xsl:value-of select="$var_EDIDValid"/>
          </small>
          <!--{EDID Invalid}-->
        </td>
      </xsl:otherwise>
    </xsl:choose>

  </xsl:template>

  <!--xsl:template match="Outputs/Input" mode="AudioFormat_TableRowCell"-->
  <xsl:template match="Outputs/Input" mode="AudioFormat_TableRowCell">
    <xsl:param name="modes" />

    <xsl:variable name="var_EDIDValid">
      <xsl:call-template name="CheckEDIDValidStatus">
        <xsl:with-param name="param_validation_list_path" select="/DigitalMediaTestReport/TestReports/OutputCapabilities/Outputs/Input" />
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="outputs-count" select="number(1)"/> <!-- TODO TO DO: count(tokenize($modes, ','))-->

    <xsl:choose>
      <xsl:when test="$var_EDIDValid = '(VALID)'">

        <xsl:variable name="mode">
            <xsl:choose>
              <xsl:when test="contains($modes, ',')">
                <xsl:value-of select="substring-before($modes, ',')" />
              </xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="$modes" />
              </xsl:otherwise>
            </xsl:choose>
          </xsl:variable>
          <td style="text-align:center;">
            <xsl:choose>
              <xsl:when test="Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode][1]">
                <xsl:apply-templates select="Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode][1]" mode="max-freq" />
              </xsl:when>
              <xsl:otherwise>
                -
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <xsl:if test="contains($modes, ',')">
            <xsl:apply-templates select="." mode="AudioFormat_TableRowCell">
              <xsl:with-param name="modes" select="substring-after($modes, ',')" />
            </xsl:apply-templates>
          </xsl:if>

      </xsl:when>
      <xsl:otherwise>
        <td colspan="12">
          <small>
            <xsl:value-of select="$var_EDIDValid"/>
          </small>
          <!--{EDID Invalid}-->
        </td>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>


  <!--xsl:template match="Input/Data/SupportedAudioFormats/AudioFormat" mode="max-freq"-->
  <xsl:template match="Input/Data/SupportedAudioFormats/AudioFormat" mode="max-freq">
    <xsl:for-each select="Frequencies/Frequency">
      <xsl:sort select="text()" order="descending" data-type="number" />
      <xsl:if test="position() = 1" >
        <xsl:value-of select="text()" />
      </xsl:if>
    </xsl:for-each>
  </xsl:template>

  <!--xsl:template match="Input/Data/SupportedAudioFormats/AudioFormat" mode="max-freq"-->
  <xsl:template match="Output/Data/SupportedAudioFormats/AudioFormat" mode="max-freq">
    <xsl:for-each select="Frequencies/Frequency">
      <xsl:sort select="text()" order="descending" data-type="number" />
      <xsl:if test="position() = 1" >
        <xsl:value-of select="text()" />
      </xsl:if>
    </xsl:for-each>
  </xsl:template>


  <xsl:template match="Inputs" mode="get-freq-list-Inputs-Input">
    <xsl:param name="mode" />
    <xsl:call-template name="FilterUniqueSequence">
      <xsl:with-param name="to_filter">
        <xsl:for-each select="Input/Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode]/Frequencies/Frequency">
          <xsl:sort select="text()" order="ascending" data-type="number" />
          <xsl:if test="position() > 1">,</xsl:if>
          <xsl:value-of select="text()" />
        </xsl:for-each>
      </xsl:with-param>
    </xsl:call-template>
  </xsl:template>

  <xsl:template match="Outputs" mode="get-freq-list-Outputs-Output">
    <xsl:param name="mode" />
    <xsl:call-template name="FilterUniqueSequence">
      <xsl:with-param name="to_filter">
        <xsl:for-each select="Output/Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode]/Frequencies/Frequency">
          <xsl:sort select="text()" order="ascending" data-type="number" />
          <xsl:if test="position() > 1">,</xsl:if>
          <xsl:value-of select="text()" />
        </xsl:for-each>
      </xsl:with-param>
    </xsl:call-template>
  </xsl:template>
  
  <xsl:template match="Outputs" mode="get-freq-list-Outputs-Input">
    <xsl:param name="mode" />
    <xsl:call-template name="FilterUniqueSequence">
      <xsl:with-param name="to_filter">
        <xsl:for-each select="Input/Data/SupportedAudioFormats/AudioFormat[concat(Format/text(), ' ', Channels/text()) = $mode]/Frequencies/Frequency">
          <xsl:sort select="text()" order="ascending" data-type="number" />
          <xsl:if test="position() > 1">,</xsl:if>
          <xsl:value-of select="text()" />
        </xsl:for-each>
      </xsl:with-param>
    </xsl:call-template>
  </xsl:template>


  <!--xsl:template match="Outputs/Output" mode="AudioFormat_TableRow"-->
  <xsl:template match="Outputs/Output" mode="AudioFormat_TableRow">
    <xsl:param name="modes" />
    <tr>
      <td style="white-space:nowrap;">
        <small>
          [Output slot <xsl:value-of select="Number"/>
          <xsl:choose>
            <xsl:when test="Type/text() = 'DMOutput'">a</xsl:when>
            <xsl:when test="Type/text() = 'HDMIOutput'">b</xsl:when>
            <xsl:otherwise>
            </xsl:otherwise>
          </xsl:choose>
          ]
        </small>
        <b>
          <xsl:value-of select="Name"/>
        </b>
        <small>
          <xsl:choose>
            <xsl:when test="contains(FirmwareName,'-Stream')">
              (<xsl:value-of select="substring-before(FirmwareName,'-Stream')"/>)
            </xsl:when>
            <xsl:otherwise>
              (<xsl:value-of select="FirmwareName"/>)
            </xsl:otherwise>
          </xsl:choose>
        </small>
        &#32;
        <xsl:choose>
          <xsl:when test="Type/text() = 'InputLocalHDMIOutput'"> (Local HDMI)</xsl:when>
          <xsl:when test="Type/text() = 'DMOutput'"> (DM)</xsl:when>
          <xsl:when test="Type/text() = 'HDMIOutput'"> (HDMI)</xsl:when>
          <xsl:otherwise>
          </xsl:otherwise>
        </xsl:choose>

      </td>

      <td></td>
      <xsl:apply-templates select="." mode="AudioFormat_TableRowCell">
        <xsl:with-param name="modes" select="$modes" />
      </xsl:apply-templates>
    </tr>
  </xsl:template>


  <!--xsl:template match="Outputs/Input" mode="AudioFormat_TableRow"-->
  <xsl:template match="Outputs/Input" mode="AudioFormat_TableRow">
    <xsl:param name="modes" />
    <tr>
      <td style="white-space:nowrap;">
        <small>
          [Input slot <xsl:value-of select="Number"/>]
        </small>
        <b>
          <xsl:value-of select="Name"/>
        </b>
        <small>
          <xsl:choose>
            <xsl:when test="contains(FirmwareName,'-Stream')">
              (<xsl:value-of select="substring-before(FirmwareName,'-Stream')"/>)
            </xsl:when>
            <xsl:otherwise>
              (<xsl:value-of select="FirmwareName"/>)
            </xsl:otherwise>
          </xsl:choose>
        </small>
        &#32;
        <xsl:choose>
          <xsl:when test="Type/text() = 'InputLocalHDMIOutput'"> (Local HDMI)</xsl:when>
          <xsl:when test="Type/text() = 'DMOutput'"> (DM)</xsl:when>
          <xsl:when test="Type/text() = 'HDMIOutput'"> (HDMI)</xsl:when>
          <xsl:otherwise>
          </xsl:otherwise>
        </xsl:choose>

      </td>

      <td></td>
      <xsl:choose>
        <xsl:when test="contains(FirmwareName, 'VID')">
          <td colspan="36">
            <small>EDID not available on analog inputs</small>
          </td>
        </xsl:when>
        <xsl:when test="contains(FirmwareName, 'SDI')">
          <td colspan="36">
            <small>EDID not available on SDI inputs</small>
          </td>
        </xsl:when>
        <xsl:otherwise>
          <xsl:apply-templates select="." mode="AudioFormat_TableRowCell">
            <xsl:with-param name="modes" select="$modes" />
          </xsl:apply-templates>
        </xsl:otherwise>
      </xsl:choose>

    </tr>
  </xsl:template>






  <xsl:template name="FilterUniqueSequence">
    <xsl:param name="current" select="''" />
    <xsl:param name="to_filter" />
    <xsl:choose>
      <xsl:when test="contains($to_filter, ',')">
        <xsl:call-template name="FilterUniqueSequence">
          <xsl:with-param name="current">
            <xsl:call-template name="FilterUniqueValue">
              <xsl:with-param name="current" select="$current" />
              <xsl:with-param name="value" select="substring-before($to_filter, ',')" />
            </xsl:call-template>
          </xsl:with-param>
          <xsl:with-param name="to_filter" select="substring-after($to_filter, ',')" />
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:call-template name="FilterUniqueValue">
          <xsl:with-param name="current" select="$current" />
          <xsl:with-param name="value" select="$to_filter" />
        </xsl:call-template>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="FilterUniqueValue">
    <xsl:param name="current" />
    <xsl:param name="value" />
    <xsl:choose>
      <xsl:when test="not ($current = $value or starts-with($current, concat($value, ',')) or contains($current, concat(',', $value, ',')) or substring($current, string-length($current) - string-length($value)) = concat(',', $value))">
        <xsl:value-of select="$current"/>
        <xsl:if test="$current != '' and $value != ''">
          <xsl:value-of select="','"/>
        </xsl:if>
        <xsl:value-of select="$value"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$current"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>





  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ========================================= "OutputCapabilities" templates ============================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <!--xsl:template match="OutputCapabilities"-->
  <xsl:template match="OutputCapabilities">

 <!--   <h2>
      <xsl:value-of select="Heading2"/>
    </h2>
    <table class="resolutionsTable">
      <tr>
        <th>Name</th>
        <th>Cable Length<br/>+/-20%<br/>(Copper only)</th>
        <th>Max Data Rate<br/>(DM CAT only)</th>
        <th>EDID<br/>Manufacturer/Model</th>
      </tr>
      <xsl:for-each select="Outputs/Output">
        <xsl:if test="Type/text() = 'DMOutput'">
          <tr>

            <td>
              <small>[<xsl:value-of select="Number"/>] </small> 
                <xsl:value-of select="Name"/>
              &#32;

            </td>



            <td style="white-space:nowrap;text-align:center;">
              <xsl:apply-templates select="Data/Cables/Cable" mode="GetAllCableLengths" />
            </td>

            <td style="white-space:nowrap;text-align:center;">
              <xsl:apply-templates select="Data/Cables/Cable" mode="GetAllMaxDataRates" />
            </td>
            
            <xsl:choose>
              <xsl:when test="Data/EDIDInfo/EDIDValid/text() = 'Valid'">
                <td>
                  <xsl:value-of select="Data/EDIDInfo/EDIDManufacture"/>
                  <br/>
                  <xsl:value-of select="Data/EDIDInfo/EDIDName"/>
                </td>
              </xsl:when>
              <xsl:otherwise>
                <td align="center" style="font-size:6px;color:white">-</td>
              </xsl:otherwise>
            </xsl:choose>
          </tr>

        </xsl:if>
      </xsl:for-each>
    </table>-->
  </xsl:template>


  <!--xsl:template name="ConcatinateSimilarNodesInfo">
    <xsl:param name="valueNode" />
    <xsl:param name="value" />
      <xsl:value-of select="$valueNode"/>,<xsl:value-of select="$value"/>)"
  </xsl:template-->

<!--  <xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable" mode="GetAllCableTypes">
    <xsl:apply-templates  select="CableType"/>
  </xsl:template>

  <xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable" mode="GetAllCableLengths">

	<xsl:choose>
	  <xsl:when test="./MeasurementStatus/text() = 'Valid'">
		<xsl:apply-templates  select="LengthInMeters"/> meters
	  </xsl:when>
	  <xsl:otherwise>
        <span style="color:red">Invalid</span>
	  </xsl:otherwise>
	</xsl:choose>
	
  </xsl:template>-->

  <!--xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable" mode="GetAllCableLengths">
    <xsl:choose>
      <xsl:when test="MeasurementStatus/text() = 'Invalid'">
        <td style="white-space:nowrap;text-align:center;">
          <xsl:apply-templates  select="Length"/>
        </td>
      </xsl:when>
      <xsl:otherwise>
        <td align="center" style="font-size:6px;color:white">
          <xsl:apply-templates  select="Length"/>
        </td>
      </xsl:otherwise>
    </xsl:choose>

  </xsl:template-->

<!--  <xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable" mode="GetAllMaxDataRates">
    <xsl:apply-templates  select="MaxDataRate"/>
  </xsl:template>-->


  <!--xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable">
    <xsl:param name="valueNode" />
    <xsl:value-of select="$valueNode"/>
    <xsl:apply-templates  select="$valueNode"/>
  </xsl:template-->

<!--  <xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable/CableType">
    <xsl:value-of select="."/>
    <small> (<xsl:value-of select="../ReportingDeviceType"/>)</small>
    <br/>
  </xsl:template>

  <xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable/Length">

    <xsl:choose>
      <xsl:when test="../MeasurementStatus/text() = 'Valid'">
        <xsl:value-of select="."/>
      </xsl:when>
      <xsl:otherwise>
        <span style="color:red">Invalid</span>
      </xsl:otherwise>
    </xsl:choose>
    <br/>
  </xsl:template>-->

  <!--xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable/Length">
    <xsl:value-of select="."/>
    <br/>
  </xsl:template-->


<!--  <xsl:template match="OutputCapabilities/Outputs/Output/Data/Cables/Cable/MaxDataRate">
    <xsl:choose>
      <xsl:when test="../MeasurementStatus/text() = 'Valid'">
        <xsl:value-of select="."/>
      </xsl:when>
      <xsl:otherwise>
        <span style="color:red">Invalid</span>
      </xsl:otherwise>
    </xsl:choose>
    <br/>
  </xsl:template>-->


<!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ========================================= "LinkQuality" templates ============================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <xsl:template name="LinkQualityTable">
	<table class="resolutionsTable">
  		<xsl:call-template name="LinkQualityTable_Title"></xsl:call-template>
  		<xsl:call-template name="LinkQualityTable_Row_Input"></xsl:call-template>
  		<xsl:call-template name="LinkQualityTable_Row_Output"></xsl:call-template>
	</table>
  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="LinkQualityTable_Title">
	<tr>
		<th>Name</th>
		<th>End-Point Device</th>
		<th>Link Status</th>
	</tr>
  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="LinkQualityTable_Row_Input">
    <xsl:for-each select="/DigitalMediaTestReport/LinkQualityData/Input">
      <tr>
		    <td>
				  <small>[Input <xsl:value-of select="Number"/>] </small> 
                  <xsl:value-of select="Name"/>
		    </td>
        <td>
			<xsl:choose>
				<xsl:when test="Data/ConnectedEndPointDeviceFirmwareName = '{INVALID}'">
					No TX
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="Data/ConnectedEndPointDeviceFirmwareName"/>
				</xsl:otherwise>
			</xsl:choose>
        </td>

  		<xsl:call-template name="LinkQualityTable_Row_LinkStatusCell"></xsl:call-template>
		
		
      </tr>
    </xsl:for-each>

  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="LinkQualityTable_Row_Output">
    <xsl:for-each select="/DigitalMediaTestReport/LinkQualityData/Output">
      <tr>
		    <td>
				  <small>[Output <xsl:value-of select="Number"/>] </small> 
                  <xsl:value-of select="Name"/>
		    </td>
			
        <td>
			<xsl:choose>
				<xsl:when test="Data/ConnectedEndPointDeviceFirmwareName = '{INVALID}'">
					No RMC
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="Data/ConnectedEndPointDeviceFirmwareName"/>
				</xsl:otherwise>
			</xsl:choose>
        </td>
	  
  		<xsl:call-template name="LinkQualityTable_Row_LinkStatusCell"></xsl:call-template>

      </tr>
	  
    </xsl:for-each>

  </xsl:template>


  <!-- ======================================================================================================================= -->
  <xsl:template name="LinkQualityTable_Row_LinkStatusCell">
	  
		<xsl:choose>
			<xsl:when test="(Data/ConnectedEndPointDeviceFirmwareName = '{INVALID}') and ((Data/LinkStatus = 'None') or (Data/LinkStatus = '{INVALID}'))">
				<td>
          No device or link failure
        </td>
			</xsl:when>
			<xsl:otherwise>

				<xsl:choose>
					<xsl:when test="Data/IsApplicableToThisDevice = 'True'">
						<xsl:choose>
							<xsl:when test="Data/LinkStatus = 'LinkIsGood'">
								<td style="color:#000000; background-color:#E0FFE0">
									Link is good
								</td>
							</xsl:when>
							<xsl:when test="Data/LinkStatus = 'LinkIsFair'">
								<td style="color:#000000; background-color:#FFFFE0">
									Link is fair
								</td>
							</xsl:when>
							<xsl:when test="Data/LinkStatus = 'LinkIsPoor'">
								<td style="color:#000000; background-color:#FFE0E0">
									Link is poor
								</td>
							</xsl:when>
						</xsl:choose>
					
					</xsl:when>
					<xsl:otherwise>
						<td style="font-size:9px;color:#000000; background-color:#E0E0E0">
							LQ only available on 8G products
						</td>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:otherwise>
		</xsl:choose>
  </xsl:template>

  <!-- ======================================================================================================================= -->
  <xsl:template name="RPSStatusTable">
  <p>
  <xsl:choose>
	
		<xsl:when test="(/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 2) or (/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 3)">
		<b>
		This unit is equipped with 
			<xsl:choose>
				<xsl:when test="/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 2">
				two  
				</xsl:when>
				<xsl:when test="/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 3">
				three  
				</xsl:when>
			</xsl:choose>
		redundant power supplies.
		</b>
			<xsl:choose>
				<xsl:when test="/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 2">
					<xsl:choose>
						<xsl:when test="(/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply1 = 'True') and (/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply2 = 'True')">
			<br/>All power supplies are functioning properly.
						</xsl:when>
						<xsl:otherwise>
							<xsl:if test="/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply1 != 'True'">
								<div style="color:#FF0000"> 
								Power supply RPS1 is not functioning properly.
								</div>
							</xsl:if>
							<xsl:if test="/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply2 != 'True'">
								<div style="color:#FF0000"> 
								Power supply RPS2 is not functioning properly.
								</div>
							</xsl:if>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:when>
				<xsl:when test="/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 3">
					<xsl:choose>
						<xsl:when test="(/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply1 = 'True') and (/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply2 = 'True') and (/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply3 = 'True')">
			<br/>All power supplies are functioning properly.
						</xsl:when>
						<xsl:otherwise>
							<xsl:if test="/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply1 != 'True'">
								<!--div style="color:#000000; background-color:#FFFFC0"--> 
								<div style="color:#FF0000"> 
								Power supply RPS1 is not functioning properly.
								</div>
							</xsl:if>
							<xsl:if test="/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply2 != 'True'">
								<div style="color:#FF0000"> 
								Power supply RPS2 is not functioning properly.
								</div>
							</xsl:if>
							<xsl:if test="/DigitalMediaTestReport/RpsStatus/StatusOfPowerSupply3 != 'True'">
								<div style="color:#FF0000"> 
								Power supply RPS3 is not functioning properly. 
								</div>
							</xsl:if>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:when>
			</xsl:choose>
		</xsl:when>
	
		<!--xsl:when test="/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 2">
		This unit is equipped with two redundant power supplies.  
		All power supplies [ARE/ARE NOT] functioning properly.
		</xsl:when>
		<xsl:when test="/DigitalMediaTestReport/RpsStatus/TotalPowerSupplies = 3">
		This unit is equipped with three redundant power supplies.  
		All power supplies [ARE/ARE NOT] functioning properly.
		</xsl:when-->
		<xsl:otherwise>
		This unit is not equipped with redundant power supplies.
		</xsl:otherwise>
	</xsl:choose>
  </p>
  </xsl:template>

  

  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- =========================================== Appendix templates ======================================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <xsl:template name="Appendix_A">

    <h2>Appendix A – Test Failures that will generate open items and important notices, and what they mean</h2>
    <h4>Open Items:</h4>
    <p>
      <table border="1">
	      <tr><th>Item</th><th>Corrective Action</th></tr>
            <!--
        <tr>
          <td>HDCP test not run</td>
          <td>Run 'HDCP Check' for the specified input from DigitalMedia Tools or the front panel of the switcher</td>
        </tr>
        <tr>
          <td>Data rate check not run</td>
          <td>Run 'Data Rate Check' for the specified output from the front panel of the switcher</td>
        </tr>
        -->
        <tr>
          <td>Output device's EDID cannot be read</td>
          <td>The device connected to the specified output may be turned off, or the device may not be communicating correctly with the DM switcher. If the device is already on, verify all cabling between the switcher and the device.</td>
        </tr>
        <tr>
          <td>Cable length check failed</td>
          <td>Re-terminate and verify the M cable on the specified output.</td>
        </tr>
      </table>
    </p>
    
    <h4>Important Notices:</h4>

      <table border="1">
	      <tr>
          <th>Item</th><th>Corrective Action</th>
        </tr>
        <tr>
          <td>Your source supports fewer KSVs than are needed in the system to route to all outputs simultaneously</td>
          <td>This is a hardware limitation of the source device. The only corrective action to enable full matrix switching is to replace the source with one that supports more KSVs. Crestron maintains a list of source KSV support here: http://www.crestron.com/hdcplimits</td>
        </tr>
        <!--tr>
          <td>Data rate check on a cable shows it supports &lt; 6.75Gbps (1080p Deep Color)</td>
          <td>The cable run may be too long to support deep color. Verify the reported data rate against the table in Appendix C to verify which AV formats are supported.</td>
        </tr-->
        <tr>
          <td>Non-DM cable is used in the system</td>
          <td>This flag is reported based on the settings applied on the front panel. The only corrective action is to install DM cable.</td>
        </tr>
        <tr>
          <td>An input EDID is configured to report support for less than 3 video resolutions.</td>
          <td>Each input should ideally be configured to support a few resolutions, so if the source cannot support some of them, it can still output the correct video format. In DigitalMedia Tools, edit the EDID on the specified input to add more video resolution to the list.</td>
        </tr>
        <tr>
          <td>Cable length too long/short</td>
          <td>The DM cable installed on this output is not of the correct length (15-150'). If you have verified the cable is the correct length, re-terminating the 'M' cable may provide a more accurate result.</td>
        </tr>


      </table>

    <p/>

  </xsl:template>
    
      <xsl:template name="Appendix_B">

    <h2>Appendix B – DEMONSTRATION AND ACCEPTANCE TESTING section of HD-DTDS</h2>
    <p>
        The demonstration and acceptance tests shall be done by a Crestron DigitalMedia Certified Engineer (DMC-E)
        The contractor shall provide a copy of the following information in electronic format in order to verify the AV switching
equipment has been installed and configured correctly:
      <ul type="disk">
<!--<li/>The number of HDCP KSVs "Keys" supported by each source-->
<li/>The video timing, HDCP use and audio format of each source when operating (not needed for walk-in
equipment)
<li/>The video timings and supported audio formats for each connected sink
<li/>The video timings and supported audio formats presented in the EDID to each source
<li/>The length of cable used on all shielded twisted pair cable used for AV distribution
<!--li/>The data rate supported by each shielded twisted pair cable used for AV distribution-->
      </ul>
    </p>
        </xsl:template>

  <xsl:template name="Appendix_C">

    <h2>Appendix C – Popular Video Timings</h2>

    <table border="1">
      <tr  align="center" bgcolor="#dddddd">
        <th>Index</th>
        <th> </th>
        <th>H Active Size</th>
        <th>V Active Size</th>
        <th>Refresh Rate (Hz)</th>
        <th>Data Rate (Gbps)</th>
        <th>Name</th>
        <th>Type</th>
      </tr>
        <xsl:for-each select="/DigitalMediaTestReport/TestReports/VideoResolutionAndAudioFormatSupportOnOutputs/VideoResolutionSupportOnOutputs/ResolutionTable/Resolution">
          <!--tr align="center">

            <xsl:variable name="var_resolutionTableBgColor">
              <xsl:choose>
                <xsl:when test="contains(VideoType/text(), 'PAL')">"#ddeeff"</xsl:when>
                <xsl:when test="contains(VideoType/text(), 'NTSC')">"#eeffee"</xsl:when>
                <xsl:otherwise>
                  "#ffffff"
                </xsl:otherwise>
              </xsl:choose>
            </xsl:variable>
            
            <xsl:variable name="var_resolutionTableTextColor">
			        <xsl:choose>
				      <xsl:when test="contains(VideoType/text(), 'PAL')">"#0000cc"</xsl:when>
				      <xsl:when test="contains(VideoType/text(), 'NTSC')">"#008800"</xsl:when>
				      <xsl:otherwise>
                "#000000"
              </xsl:otherwise>
			        </xsl:choose>
            </xsl:variable>

            <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}"><xsl:value-of select="Index/text()"/></td>
            <td> </td>
            <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}"><xsl:value-of select="HActiveSizePixels/text()"/></td>
            <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}"><xsl:value-of select="VActiveSizePixels/text()"/></td>
            <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}"><xsl:value-of select="RefreshRateHz/text()"/></td>
            <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}"><xsl:value-of select="format-number(PixelClockMHz/text() * 0.03, '0.00')"/></td>
            <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}"><xsl:value-of select="Name/text()"/></td>
            <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}"><xsl:value-of select="VideoType/text()"/></td>
          </tr-->

          <xsl:call-template name="Appendix_C__TableRow">
            <xsl:with-param name="param_name" select="Name/text()" />
            <xsl:with-param name="param_data_rate" select="format-number(PixelClockMHz/text() * 0.03, '0.00')" />
          </xsl:call-template>

          <xsl:variable name="var_name_for_deep_color">
            <xsl:value-of select="Name/text()"/> (Deep Color)
          </xsl:variable>
          
          <xsl:variable name="var_data_rate_for_deep_color">
            <xsl:value-of select="format-number(225 * 0.03, '0.00')"/>
          </xsl:variable>

          <xsl:choose>
            <xsl:when test="Index = 31">
              <xsl:call-template name="Appendix_C__TableRow">
                <xsl:with-param name="param_name" select="$var_name_for_deep_color" />
                <xsl:with-param name="param_data_rate" select="$var_data_rate_for_deep_color" />
              </xsl:call-template>
            </xsl:when>
            <xsl:when test="Index = 32">
              <xsl:call-template name="Appendix_C__TableRow">
                <xsl:with-param name="param_name" select="$var_name_for_deep_color" />
                <xsl:with-param name="param_data_rate" select="$var_data_rate_for_deep_color" />
              </xsl:call-template>
            </xsl:when>
            <xsl:otherwise>
            </xsl:otherwise>
          </xsl:choose>

        </xsl:for-each>
    </table>

  </xsl:template>

  <xsl:template name="Appendix_C__TableRow">
    <xsl:param name="param_name" />
    <xsl:param name="param_data_rate" />

    <tr align="center">

          <xsl:variable name="var_resolutionTableBgColor">
            <xsl:choose>
              <xsl:when test="contains(VideoType/text(), 'PAL')">"#ddeeff"</xsl:when>
              <xsl:when test="contains(VideoType/text(), 'NTSC')">"#eeffee"</xsl:when>
              <xsl:otherwise>
                "#ffffff"
              </xsl:otherwise>
            </xsl:choose>
          </xsl:variable>

          <xsl:variable name="var_resolutionTableTextColor">
            <xsl:choose>
              <xsl:when test="contains(VideoType/text(), 'PAL')">"#0000cc"</xsl:when>
              <xsl:when test="contains(VideoType/text(), 'NTSC')">"#008800"</xsl:when>
              <xsl:otherwise>
                "#000000"
              </xsl:otherwise>
            </xsl:choose>
          </xsl:variable>

          <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}">
            <xsl:value-of select="Index/text()"/>
          </td>
          <td> </td>
          <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}">
            <xsl:value-of select="HActiveSizePixels/text()"/>
          </td>
          <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}">
            <xsl:value-of select="VActiveSizePixels/text()"/>
          </td>
          <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}">
            <xsl:value-of select="RefreshRateHz/text()"/>
          </td>
          <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}">
            <xsl:value-of select="$param_data_rate"/>
          </td>
          <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}">
            <xsl:value-of select="$param_name"/>
          </td>
          <td style="color:{$var_resolutionTableTextColor}; background-color:{$var_resolutionTableBgColor}">
            <xsl:value-of select="VideoType/text()"/>
          </td>
        </tr>

  </xsl:template>


  <!--                                       ====================================                                              -->
  <!--                   ====================================================================================                  -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!-- ============================================= Helper templates ======================================================== -->
  <!-- ======================================================================================================================= -->
  <!-- ======================================================================================================================= -->
  <!--                   ====================================================================================                  -->
  <!--                                       ====================================                                              -->

  <xsl:template name="CopySorceXmlDocument" match="@*|node()">
    <xsl:copy>
      <xsl:apply-templates select="@*|node()"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template name="GetOutputEDIDValidStateList">
    <xsl:param name="param_path" />
    <!--xsl:for-each select="/DigitalMediaTestReport/TestReports/OutputCapabilities/Outputs/Output"-->
    <xsl:for-each select="$param_path">
        <xsl:choose>
        <xsl:when test="(Data/EDIDInfo/HotplugStatus='ON') and (Data/EDIDInfo/EDIDValid='Valid')">[<xsl:value-of select="Number"/>:<xsl:value-of select="Type"/>](VALID)</xsl:when>
        <xsl:when test="(Data/EDIDInfo/HotplugStatus='ON') and (Data/EDIDInfo/EDIDValid='Invalid')">[<xsl:value-of select="Number"/>:<xsl:value-of select="Type"/>]EDID cannot be read from sink. Check cabling and ensure sink device is on.</xsl:when>
        <xsl:when test="(Data/EDIDInfo/HotplugStatus='OFF')">[<xsl:value-of select="Number"/>:<xsl:value-of select="Type"/>]Not Connected</xsl:when>
        <xsl:otherwise>[<xsl:value-of select="Number"/>:<xsl:value-of select="Type"/>](INVALID)</xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>
  </xsl:template>


  <xsl:template name="ValidateOutputEDID">
    <xsl:param name="param_number" />
    <xsl:param name="param_type" />
    <xsl:param name="param_validation_list" />


    <xsl:variable name="var_param_for_search">[<xsl:value-of select="$param_number"/>:<xsl:value-of select="$param_type"/>]</xsl:variable>

    <xsl:variable name="var_search_result_1" select="substring-after($param_validation_list, $var_param_for_search)" />
    <xsl:variable name="var_search_result_2" select="substring-before($var_search_result_1, '[')" />

    <!--
    [SEARCH:<xsl:value-of select="$var_param_for_search"/>]
    [LIST:<xsl:value-of select="$param_validation_list"/>]
    [result_1:<xsl:value-of select="$var_search_result_1"/>]
    [result_2:<xsl:value-of select="$var_search_result_2"/>]
    -->

    <xsl:choose>
      <xsl:when test="string-length($var_search_result_2) > 0">
        <xsl:value-of select="$var_search_result_2"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$var_search_result_1"/>
      </xsl:otherwise>
    </xsl:choose>


  </xsl:template>


  <!--NOT USED 
  xsl:template name="DoValidateOutputEDID">
    <xsl:param name="param_validation_list_path" />
    <xsl:param name="param_table_row_template_mode" />

    <xsl:variable name="var_EDID_validation_list">
      <xsl:call-template name="GetOutputEDIDValidStateList">
        <xsl:with-param name="param_path" select="$param_validation_list_path"/>
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="var_EDIDValid">
      <xsl:call-template name="ValidateOutputEDID">
        <xsl:with-param name="param_number" select="Number" />
        <xsl:with-param name="param_type" select="Type"/>
        <xsl:with-param name="param_validation_list" select="$var_EDID_validation_list"/>
      </xsl:call-template>
    </xsl:variable>


    <xsl:choose>
      <xsl:when test="$var_EDIDValid = '(VALID)'">
        <xsl:choose>
          <xsl:when test="$param_table_row_template_mode = 'VideoResolution_TableRowCell'">
            <xsl:apply-templates select="Data" mode="VideoResolution_TableRowCell"/>
          </xsl:when>
          <xsl:otherwise>
          </xsl:otherwise>
        </xsl:choose>
      </xsl:when>
      <xsl:otherwise>
        <td style="color:red">
          <small>
            <xsl:value-of select="$var_EDIDValid"/>
            [<xsl:value-of select="$param_table_row_template_mode"/>]
          </small>
        </td>
      </xsl:otherwise>
    </xsl:choose>

  </xsl:template-->


  <xsl:template name="CheckEDIDValidStatus">
    <xsl:param name="param_validation_list_path" />

    <xsl:variable name="var_EDID_validation_list">
      <xsl:call-template name="GetOutputEDIDValidStateList">
        <xsl:with-param name="param_path" select="$param_validation_list_path"/>
      </xsl:call-template>
    </xsl:variable>

    <xsl:variable name="var_EDIDValid">
      <xsl:call-template name="ValidateOutputEDID">
        <xsl:with-param name="param_number" select="Number" />
        <xsl:with-param name="param_type" select="Type"/>
        <xsl:with-param name="param_validation_list" select="$var_EDID_validation_list"/>
      </xsl:call-template>
    </xsl:variable>


    <xsl:choose>
      <xsl:when test="$var_EDIDValid = '(VALID)'">(VALID)</xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$var_EDIDValid"/>
      </xsl:otherwise>
    </xsl:choose>



  </xsl:template>


</xsl:stylesheet>
<!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="QE 16X16e - Test System 16X16DMLab.xml" htmlbaseurl="" outputurl="" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength=""
		          urlprofilexml="" commandline="" additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext="" validateoutput="no" validator="internal"
		          customvalidator="">
			<advancedProp name="sInitialMode" value=""/>
			<advancedProp name="bXsltOneIsOkay" value="true"/>
			<advancedProp name="bSchemaAware" value="true"/>
			<advancedProp name="bXml11" value="false"/>
			<advancedProp name="iValidation" value="0"/>
			<advancedProp name="bExtensions" value="true"/>
			<advancedProp name="iWhitespace" value="0"/>
			<advancedProp name="sInitialTemplate" value=""/>
			<advancedProp name="bTinyTree" value="true"/>
			<advancedProp name="bWarnings" value="true"/>
			<advancedProp name="bUseDTD" value="false"/>
			<advancedProp name="iErrorHandling" value="fatal"/>
		</scenario>
	</scenarios>
	<MapperMetaTag>
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="" destSchemaRoot="" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no"/>
		<MapperBlockPosition></MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->