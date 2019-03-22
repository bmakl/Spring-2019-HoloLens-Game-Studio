//Maya ASCII 2018 scene
//Name: Start-End.ma
//Last modified: Tue, Mar 05, 2019 07:18:06 PM
//Codeset: 1252
requires maya "2018";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2018";
fileInfo "version" "2018";
fileInfo "cutIdentifier" "201706261615-f9658c4cfc";
fileInfo "osv" "Microsoft Windows 8 Home Premium Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -s -n "persp";
	rename -uid "FC9745C7-4941-3449-BF6A-B7833BBE87FC";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 16.675224948881034 13.089726094933265 -18.784022071876773 ;
	setAttr ".r" -type "double3" -743.13835269162996 -2370.2000000000103 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "CD65C579-4342-C24A-E1B2-A1965E84612C";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 22.504177690257769;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".hc" -type "string" "viewSet -p %camera";
	setAttr ".ai_translator" -type "string" "perspective";
createNode transform -s -n "top";
	rename -uid "D2DC73E2-4DB3-7EF9-7F44-939C84BB0D81";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 1000.1 0 ;
	setAttr ".r" -type "double3" -89.999999999999986 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "7920F2B4-4E31-D98B-06A1-41901AA24155";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "front";
	rename -uid "A87715C5-41ED-9178-BB24-BD89196B6824";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "50C4E00B-4D8F-28B9-F4B3-B1945F3F7E52";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "side";
	rename -uid "7EC8BB6D-407C-05BD-2ED6-8A8E3D12406D";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.1 0 0 ;
	setAttr ".r" -type "double3" 0 89.999999999999986 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "0A227411-4D49-C2BA-CCFA-6AB943B6A96E";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -n "pCube1";
	rename -uid "94D573CE-4467-DC68-B700-778F98853B21";
	setAttr ".t" -type "double3" 0 5.9361982345581357 0 ;
	setAttr ".s" -type "double3" 9.2928086270091068 11.974801385335542 9.2928086270091068 ;
	setAttr ".rp" -type "double3" -0.1724182363894933 1.7843846258258511e-07 5.5389455717856329e-07 ;
	setAttr ".sp" -type "double3" -0.018553942441940308 1.4901161193847656e-08 5.9604644775390625e-08 ;
	setAttr ".spt" -type "double3" -0.15386429394755299 1.6353730138873746e-07 4.9428991240317266e-07 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "04653B3D-41EF-A63B-7F6F-D4A1C929BC28";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.70493578910827637 0.30172417312860489 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "04FC8C6A-4456-FE50-5AC4-2C8F2A067249";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "9E48C9AA-4E3E-EBFD-76F2-DD8A7D45939F";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "1B66CAA4-4EF5-439B-575E-D38344EC2483";
createNode displayLayerManager -n "layerManager";
	rename -uid "6B329FC5-4577-4F35-FB09-1895087DD4B9";
createNode displayLayer -n "defaultLayer";
	rename -uid "C99B5701-48E3-4DA6-285C-A2B14386B76F";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "4B85F597-45B1-76F0-F822-4699972401F2";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "6ED893F4-477A-C2C4-A37D-6B90EFFB3A14";
	setAttr ".g" yes;
createNode polyCube -n "polyCube1";
	rename -uid "4BCFDF9C-4AD0-F31A-99AC-1FA4C54E1E4C";
	setAttr ".cuv" 4;
createNode polyTweakUV -n "polyTweakUV1";
	rename -uid "8F5868FE-42E9-5FEE-2D0D-6695D23A154E";
	setAttr ".uopa" yes;
	setAttr -s 14 ".uvtk[0:13]" -type "float2" 0.0079190629 -0.0038532191
		 0.013687929 -0.0034868671 -0.055399407 -0.046710413 0.019999024 -0.028387267 -0.040239293
		 0.018799618 0.0007104965 0.019281793 0.020983433 0.015277182 -0.0012468548 0.016562697
		 0.024335604 -0.018510085 -3.0462777e-05 -0.018452739 -0.034671605 0.0083422074 0.029034618
		 -0.005610595 0.050040692 0.014437351 -0.040277585 -0.01020095;
createNode polyTweak -n "polyTweak1";
	rename -uid "70DAF470-4240-F021-3235-04B58859CE44";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk[0:7]" -type "float3"  0.096772939 0.0091518518 -0.07545045
		 0 0.0034401454 -0.075450256 -0.096772946 -0.0091518499 0.075450391 0 -0.0034401044
		 0.075450212 -0.096772924 -0.0091519402 -0.075450227 0 -0.0034401342 -0.075450316
		 0.096772939 0.0091518862 0.075450227 0 0.0034401566 0.075450316;
createNode polySplit -n "polySplit1";
	rename -uid "BF8D6DA7-4C55-EECF-3F7F-0696F2A96408";
	setAttr -s 5 ".e[0:4]"  0.89999998 0.89999998 0.1 0.1 0.89999998;
	setAttr -s 5 ".d[0:4]"  -2147483644 -2147483643 -2147483639 -2147483640 -2147483644;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "041C4CE5-42BF-727B-0E0D-1AB3C08E655D";
	setAttr ".ics" -type "componentList" 1 "f[4]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 4.6464043 11.287784 -5.5389455e-07 ;
	setAttr ".rs" 64403;
	setAttr ".lt" -type "double3" -4.4775044866291246e-24 1.5100692378503008e-16 1.2330651081615285 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.6464043135045534 10.693162706653194 -5.3475495231308088 ;
	setAttr ".cbx" -type "double3" 4.6464043135045534 11.882404270773069 5.347548415341695 ;
createNode polySplit -n "polySplit2";
	rename -uid "00462276-4018-5B5F-B1FF-81A829C91F41";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483622 -2147483641;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit3";
	rename -uid "F9D6DF14-44D3-834A-E7A2-0982A166F323";
	setAttr -s 2 ".e[0:1]"  1 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483641 -2147483642;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace2";
	rename -uid "65E6470C-4F41-D2E3-E759-16B6C7BE8E70";
	setAttr ".ics" -type "componentList" 2 "f[12]" "f[14]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.2629366 11.882402 -5.5389455e-07 ;
	setAttr ".rs" 64527;
	setAttr ".lt" -type "double3" 0 3.1709566048014133e-16 1.4280718983791658 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.6464043135045534 11.882399988250373 -5.3475495231308088 ;
	setAttr ".cbx" -type "double3" 5.8794688676478701 11.882404627649962 5.347548415341695 ;
createNode polyTweakUV -n "polyTweakUV2";
	rename -uid "5F1D3D12-4261-7431-11C9-EDB3F4399FC4";
	setAttr ".uopa" yes;
	setAttr -s 6 ".uvtk";
	setAttr ".uvtk[5]" -type "float2" 0.002026696 0.0011617746 ;
	setAttr ".uvtk[11]" -type "float2" -0.00046634968 -0.0036005387 ;
	setAttr ".uvtk[22]" -type "float2" -0.00060936832 -0.0049899938 ;
	setAttr ".uvtk[33]" -type "float2" -5.019087e-06 -4.4132182e-07 ;
	setAttr ".uvtk[34]" -type "float2" -2.2738303e-05 -0.0001327193 ;
createNode polyMergeVert -n "polyMergeVert1";
	rename -uid "4E465C29-4015-C22A-5951-778ED14C938A";
	setAttr ".ics" -type "componentList" 3 "vtx[5]" "vtx[14]" "vtx[23:24]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak2";
	rename -uid "6507EDF4-49C2-78E8-143D-E688764F2DF3";
	setAttr ".uopa" yes;
	setAttr -s 13 ".tk";
	setAttr ".tk[16]" -type "float3" 0 -2.0861626e-07 0 ;
	setAttr ".tk[17]" -type "float3" 0 -3.8743019e-07 0 ;
	setAttr ".tk[18]" -type "float3" 0 -1.4901161e-07 0 ;
	setAttr ".tk[19]" -type "float3" 0 0.3371262 0 ;
	setAttr ".tk[20]" -type "float3" 0 0.3371262 0 ;
	setAttr ".tk[21]" -type "float3" 0 -0.08118616 0 ;
	setAttr ".tk[22]" -type "float3" 0 -0.08118616 0 ;
	setAttr ".tk[23]" -type "float3" 0 -0.11925636 0 ;
	setAttr ".tk[24]" -type "float3" 0 -0.11925636 0 ;
createNode polyTweakUV -n "polyTweakUV3";
	rename -uid "A8D47732-4BFE-E3D1-8A0D-A289A1D7F11F";
	setAttr ".uopa" yes;
	setAttr -s 5 ".uvtk";
	setAttr ".uvtk[3]" -type "float2" -0.0081288172 -0.01109577 ;
	setAttr ".uvtk[23]" -type "float2" -0.00087229779 -0.0047696168 ;
	setAttr ".uvtk[30]" -type "float2" 5.019087e-06 4.4132182e-07 ;
	setAttr ".uvtk[31]" -type "float2" -0.00029290869 -0.00040698476 ;
createNode polyMergeVert -n "polyMergeVert2";
	rename -uid "4FD527A8-4CD3-0793-4E9D-358CAEF9C210";
	setAttr ".ics" -type "componentList" 3 "vtx[3]" "vtx[15]" "vtx[21:22]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".d" 1e-06;
createNode polyTweak -n "polyTweak3";
	rename -uid "B689E3D2-463C-E175-5563-25BA6C0BA655";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk";
	setAttr ".tk[21]" -type "float3" 0 -0.038070202 0 ;
	setAttr ".tk[22]" -type "float3" 0 -0.038070202 0 ;
createNode polyTweak -n "polyTweak4";
	rename -uid "71CD9869-44CE-60A4-32D3-D0A913AD12B9";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[2]" -type "float3" 0 -0.074124835 0 ;
	setAttr ".tk[3]" -type "float3" 0 7.4505806e-09 0 ;
	setAttr ".tk[4]" -type "float3" 0 -0.074124835 0 ;
	setAttr ".tk[5]" -type "float3" 0 7.4505806e-09 0 ;
	setAttr ".tk[17]" -type "float3" 0 0.30124268 0 ;
createNode polySplit -n "polySplit4";
	rename -uid "B1D65B21-4C48-C507-9807-0689C66A210E";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483631 -2147483626;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit5";
	rename -uid "1E6D51C5-4169-8A28-5C01-A4A46E600F39";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483626 -2147483631;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit6";
	rename -uid "6DC1239F-4A74-E72A-E586-F08EB1984D3E";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483609 -2147483608;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit7";
	rename -uid "2FC033ED-4977-0175-A393-79AD2A971A5F";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483631 -2147483626;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit8";
	rename -uid "D05CEE3E-4514-BE39-B31A-7F887C057B93";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483603 -2147483602;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit9";
	rename -uid "0AB9DF91-48D3-FE9A-DB50-B3B3D92783FF";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483605 -2147483606;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit10";
	rename -uid "E71EB1AD-4A6C-B69A-4D18-A483A37A7E51";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483609 -2147483608;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit11";
	rename -uid "50C0DBD2-4351-BBA4-9D2E-98A68C334A72";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483609 -2147483608;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit12";
	rename -uid "74FFB212-4691-F403-068C-4AA3FF93093C";
	setAttr -s 2 ".e[0:1]"  0.5 0.5;
	setAttr -s 2 ".d[0:1]"  -2147483594 -2147483593;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode deleteComponent -n "deleteComponent1";
	rename -uid "7ED9AE06-4811-A7AA-1D10-668A86FD9D9D";
	setAttr ".dc" -type "componentList" 1 "e[41]";
createNode polySplit -n "polySplit13";
	rename -uid "14477072-4E8D-588E-ED0F-87B8A0714D81";
	setAttr -s 2 ".e[0:1]"  1 0;
	setAttr -s 2 ".d[0:1]"  -2147483619 -2147483618;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit14";
	rename -uid "2DA4B85C-4BC4-04C4-5014-05A4833F5709";
	setAttr -s 2 ".e[0:1]"  1 1;
	setAttr -s 2 ".d[0:1]"  -2147483617 -2147483647;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyTweak -n "polyTweak5";
	rename -uid "94D90AE2-488A-67C2-7E6E-5D9328E96FB4";
	setAttr ".uopa" yes;
	setAttr -s 22 ".tk";
	setAttr ".tk[10]" -type "float3" -9.3132257e-10 0 9.3132257e-10 ;
	setAttr ".tk[13]" -type "float3" 9.3132257e-10 0 9.3132257e-10 ;
	setAttr ".tk[18]" -type "float3" -0.10534655 0.048413426 0 ;
	setAttr ".tk[29]" -type "float3" -9.3132257e-10 0 -9.3132257e-10 ;
	setAttr ".tk[30]" -type "float3" 9.3132257e-10 0 -9.3132257e-10 ;
	setAttr ".tk[39]" -type "float3" 1.8626451e-09 -5.5511151e-17 -1.4901161e-08 ;
	setAttr ".tk[40]" -type "float3" -1.8626451e-09 -5.5511151e-17 -1.4901161e-08 ;
	setAttr ".tk[41]" -type "float3" 1.8626451e-09 -5.5511151e-17 -4.6566129e-08 ;
	setAttr ".tk[42]" -type "float3" -1.8626451e-09 -5.5511151e-17 -4.6566129e-08 ;
	setAttr ".tk[43]" -type "float3" 4.6566129e-10 0 -7.4505806e-09 ;
	setAttr ".tk[44]" -type "float3" 4.6566129e-10 0 1.8626451e-09 ;
	setAttr ".tk[45]" -type "float3" -4.6566129e-10 0 1.8626451e-09 ;
	setAttr ".tk[46]" -type "float3" -4.6566129e-10 0 -7.4505806e-09 ;
	setAttr ".tk[47]" -type "float3" 4.6566129e-10 0 -1.8626451e-09 ;
	setAttr ".tk[48]" -type "float3" -4.6566129e-10 0 -1.8626451e-09 ;
	setAttr ".tk[49]" -type "float3" 4.6566129e-10 0 7.4505806e-09 ;
	setAttr ".tk[50]" -type "float3" -4.6566129e-10 0 7.4505806e-09 ;
	setAttr ".tk[51]" -type "float3" 4.6566129e-10 0 1.8626451e-09 ;
	setAttr ".tk[52]" -type "float3" -4.6566129e-10 0 1.8626451e-09 ;
	setAttr ".tk[53]" -type "float3" 4.6566129e-10 0 3.7252903e-09 ;
	setAttr ".tk[54]" -type "float3" -4.6566129e-10 0 3.7252903e-09 ;
createNode polySplit -n "polySplit15";
	rename -uid "5059D8A1-490E-9E35-372B-6A99AAC07DF1";
	setAttr -s 5 ".e[0:4]"  0.2 0.2 0.80000001 0.80000001 0.2;
	setAttr -s 5 ".d[0:4]"  -2147483644 -2147483643 -2147483634 -2147483633 -2147483644;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace3";
	rename -uid "A8615BFF-4126-FCF5-1D99-CDA2FAA9DBEF";
	setAttr ".ics" -type "componentList" 1 "f[30:33]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 0.2877737 1.0821968 1.3847364e-07 ;
	setAttr ".rs" 51603;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -4.070856910296766 -0.010007444779872365 -4.1976716230573548 ;
	setAttr ".cbx" -type "double3" 4.6464043135045534 2.1744010336322517 4.1976719000046332 ;
createNode polyExtrudeFace -n "polyExtrudeFace4";
	rename -uid "7BC59EC7-4391-2B01-9C3C-6EAFA8C11DDA";
	setAttr ".ics" -type "componentList" 2 "f[17]" "f[19]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.8794689 14.614949 -5.5389455e-07 ;
	setAttr ".rs" 61386;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 5.8794688676478701 11.882402486388612 -5.3475495231308088 ;
	setAttr ".cbx" -type "double3" 5.8794688676478701 17.347496004626851 5.347548415341695 ;
createNode polyTweak -n "polyTweak6";
	rename -uid "F30BC9C3-4316-ED84-5122-2E81203A6D7F";
	setAttr ".uopa" yes;
	setAttr -s 11 ".tk";
	setAttr ".tk[43]" -type "float3" -0.041434359 1.3969839e-09 0.040514015 ;
	setAttr ".tk[44]" -type "float3" 0.18482102 -9.3132257e-10 0.040514015 ;
	setAttr ".tk[45]" -type "float3" 0.18482102 -4.6566129e-10 0.043106079 ;
	setAttr ".tk[46]" -type "float3" -0.044758957 9.3132257e-10 0.043106075 ;
	setAttr ".tk[47]" -type "float3" 0.18482102 -9.3132257e-10 -0.040514015 ;
	setAttr ".tk[48]" -type "float3" 0.18482102 -4.6566129e-10 -0.043106068 ;
	setAttr ".tk[49]" -type "float3" -0.044758957 9.3132257e-10 -0.043106079 ;
	setAttr ".tk[50]" -type "float3" -0.041434359 1.3969839e-09 -0.040514071 ;
createNode polyExtrudeFace -n "polyExtrudeFace5";
	rename -uid "0B35449A-43EF-36C9-36A5-1A83E4990CDD";
	setAttr ".ics" -type "componentList" 2 "f[17]" "f[19]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.8794689 14.523406 -5.5389455e-07 ;
	setAttr ".rs" 47217;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 5.8794688676478701 12.223187798769128 -4.5014910960881549 ;
	setAttr ".cbx" -type "double3" 5.8794688676478701 16.823624995659145 4.5014899882990402 ;
createNode polyTweak -n "polyTweak7";
	rename -uid "7B315775-4DC3-C791-EF3D-D882A1DF0A68";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[51:54]" -type "float3"  0 0.028458465 -0.091044441
		 0 0.02845851 5.79622e-18 0 -0.043747757 5.79622e-18 0 0.028458465 0.091044441;
createNode polyTweak -n "polyTweak8";
	rename -uid "27513586-45E3-71DC-FBE7-DA8DEADEB268";
	setAttr ".uopa" yes;
	setAttr -s 9 ".tk";
	setAttr ".tk[55]" -type "float3" -0.07070297 0 0 ;
	setAttr ".tk[56]" -type "float3" -0.07070297 0 0 ;
	setAttr ".tk[57]" -type "float3" -0.07070297 0 0 ;
	setAttr ".tk[58]" -type "float3" -0.07070297 0 0 ;
createNode deleteComponent -n "deleteComponent2";
	rename -uid "6B3FD0F7-4B95-9DE1-F6A6-9A807DB1C8D1";
	setAttr ".dc" -type "componentList" 2 "e[58]" "e[61]";
createNode polyExtrudeFace -n "polyExtrudeFace6";
	rename -uid "F5365549-44E0-A55F-7068-579B8F881409";
	setAttr ".ics" -type "componentList" 1 "f[20]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.2629366 10.693163 4.5564051 ;
	setAttr ".rs" 64577;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.6464043135045534 10.693163063530086 3.9054897516201557 ;
	setAttr ".cbx" -type "double3" 5.8794688676478701 10.693163063530086 5.2073200380899118 ;
createNode polyExtrudeFace -n "polyExtrudeFace7";
	rename -uid "3AD2A48E-436D-11F4-DABF-FDA86752C221";
	setAttr ".ics" -type "componentList" 1 "f[20]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.364254 10.693163 4.5564051 ;
	setAttr ".rs" 58057;
	setAttr ".lt" -type "double3" 0 -0.89678040779881107 8.75 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.9374360228937713 10.693163063530086 4.1057838393887742 ;
	setAttr ".cbx" -type "double3" 5.7910722813731859 10.693163063530086 5.0070262272685717 ;
createNode polyTweak -n "polyTweak9";
	rename -uid "393251C9-4E95-51F1-B18E-C8A517C7D179";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[59]" -type "float3" 0.031317949 0 -0.021553662 ;
	setAttr ".tk[60]" -type "float3" 0.031317949 0 0.021553664 ;
	setAttr ".tk[61]" -type "float3" -0.009512363 0 0.021553664 ;
	setAttr ".tk[62]" -type "float3" -0.009512363 0 -0.021553662 ;
createNode polyExtrudeFace -n "polyExtrudeFace8";
	rename -uid "67A2D83E-4428-44D3-4E6F-0FAABF392C37";
	setAttr ".ics" -type "componentList" 1 "f[10]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.2629366 10.693163 1.952745 ;
	setAttr ".rs" 37518;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.6464043135045534 10.693163063530086 1.301830009522478 ;
	setAttr ".cbx" -type "double3" 5.8794688676478701 10.693163063530086 2.6036600190449559 ;
createNode polyExtrudeFace -n "polyExtrudeFace9";
	rename -uid "81578716-4C66-34A9-93B3-0CB4C98E5BD5";
	setAttr ".ics" -type "componentList" 1 "f[10]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.4268184 10.693162 1.952745 ;
	setAttr ".rs" 44324;
	setAttr ".lt" -type "double3" 0 8.9629066965376746e-17 8.5963465674131641 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 5.010421047009519 10.69316163602252 1.5131259664066954 ;
	setAttr ".cbx" -type "double3" 5.8432159149859757 10.69316163602252 2.3923639236870993 ;
createNode polyTweak -n "polyTweak10";
	rename -uid "3E03F071-45E0-DA22-664F-A381EAFEB6EE";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[67:70]" -type "float3"  -0.0039011887 -1.1920929e-07
		 -0.022737579 0.039171882 -1.1920929e-07 -0.022737579 0.039171882 -1.1920929e-07 0.022737578
		 -0.0039011887 -1.1920929e-07 0.022737578;
createNode deleteComponent -n "deleteComponent3";
	rename -uid "DE8A1C05-4270-C564-5ED4-4B8FBFE71F95";
	setAttr ".dc" -type "componentList" 4 "f[3]" "f[32]" "f[34]" "f[37:38]";
createNode deleteComponent -n "deleteComponent4";
	rename -uid "E1DD9B8F-4C39-DD36-F9B0-4C9CCD40D20F";
	setAttr ".dc" -type "componentList" 2 "f[9]" "f[19]";
createNode polySplit -n "polySplit16";
	rename -uid "DBF72EAE-4954-A44E-532A-A1B5CEEBA7CD";
	setAttr -s 3 ".e[0:2]"  0.5 0.5 0.5;
	setAttr -s 3 ".d[0:2]"  -2147483587 -2147483575 -2147483578;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit17";
	rename -uid "28FF9200-41A8-9E36-3904-90BF4EBC8ADA";
	setAttr -s 3 ".e[0:2]"  0.69999999 0.69999999 0.30000001;
	setAttr -s 3 ".d[0:2]"  -2147483587 -2147483575 -2147483517;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polySplit -n "polySplit18";
	rename -uid "12507D09-44A0-E66D-A9F6-A98EC52AAF13";
	setAttr -s 3 ".e[0:2]"  0.69999999 0.30000001 0.30000001;
	setAttr -s 3 ".d[0:2]"  -2147483578 -2147483518 -2147483519;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode deleteComponent -n "deleteComponent5";
	rename -uid "1D506227-4EDF-1A81-1287-9C95C437FB67";
	setAttr ".dc" -type "componentList" 1 "e[132:133]";
createNode deleteComponent -n "deleteComponent6";
	rename -uid "3207B091-4D63-16D9-2252-43B018B3E4B5";
	setAttr ".dc" -type "componentList" 2 "vtx[17:18]" "vtx[31:34]";
createNode deleteComponent -n "deleteComponent7";
	rename -uid "47FEC820-45DE-1D52-99C3-E0932A2D7851";
	setAttr ".dc" -type "componentList" 2 "vtx[65]" "vtx[67]";
createNode deleteComponent -n "deleteComponent8";
	rename -uid "FC2F4C3D-44E8-A2CD-EA7A-3A8B521594B7";
	setAttr ".dc" -type "componentList" 1 "vtx[65]";
createNode polyExtrudeFace -n "polyExtrudeFace10";
	rename -uid "0131A523-4E48-E2A2-2D31-569E054752AE";
	setAttr ".ics" -type "componentList" 1 "f[22]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.2629366 10.693163 -1.952745 ;
	setAttr ".rs" 33120;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.6464043135045534 10.693163063530086 -2.6036600190449559 ;
	setAttr ".cbx" -type "double3" 5.8794688676478701 10.693163063530086 -1.301830009522478 ;
createNode polyExtrudeFace -n "polyExtrudeFace11";
	rename -uid "20BCF568-4AD4-7BCB-9594-B3B93D295173";
	setAttr ".ics" -type "componentList" 1 "f[22]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.3955026 10.693163 -1.9527451 ;
	setAttr ".rs" 36156;
	setAttr ".lt" -type "double3" 0 1.0937689787693153e-16 8.5074102434785104 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.9463858511486629 10.693163063530086 -2.4269083885873761 ;
	setAttr ".cbx" -type "double3" 5.8446194837938661 10.693163063530086 -1.4785817784536972 ;
createNode polyTweak -n "polyTweak11";
	rename -uid "1325FA59-43D2-3539-AC98-EA93A4EB8A12";
	setAttr ".uopa" yes;
	setAttr -s 8 ".tk";
	setAttr ".tk[71]" -type "float3" 0.032281015 0 -0.019020274 ;
	setAttr ".tk[72]" -type "float3" -0.003750144 0 -0.019020274 ;
	setAttr ".tk[73]" -type "float3" 0.032281015 0 0.019020274 ;
	setAttr ".tk[74]" -type "float3" -0.003750144 0 0.019020274 ;
createNode polyExtrudeFace -n "polyExtrudeFace12";
	rename -uid "96A2E210-44FF-B338-CFD4-8381144D0A0B";
	setAttr ".ics" -type "componentList" 1 "f[20]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.2629366 10.693163 -4.5564051 ;
	setAttr ".rs" 53787;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.6464043135045534 10.693163063530086 -5.2073200380899118 ;
	setAttr ".cbx" -type "double3" 5.8794688676478701 10.693163063530086 -3.9054897516201557 ;
createNode polyExtrudeFace -n "polyExtrudeFace13";
	rename -uid "4631DFBF-45B6-D053-1C2F-E6B85B7FB526";
	setAttr ".ics" -type "componentList" 1 "f[20]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 5.4098549 10.693163 -4.5564046 ;
	setAttr ".rs" 41146;
	setAttr ".lt" -type "double3" 0 0.87643169985894276 8.7864864594320711 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.9743730353337812 10.693163063530086 -5.0161726880912614 ;
	setAttr ".cbx" -type "double3" 5.8453367772454126 10.693163063530086 -4.0966368246715277 ;
createNode polyTweak -n "polyTweak12";
	rename -uid "581096D4-476A-6AAB-E350-FCA825E9BEB0";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk[79:82]" -type "float3"  0.035292745 0 -0.020569358
		 -0.0036729327 0 -0.020569358 0.035292745 0 0.020569358 -0.0036729327 0 0.020569358;
createNode polyTweak -n "polyTweak13";
	rename -uid "1ABABC0F-4E9B-CD60-942E-3A89106C0202";
	setAttr ".uopa" yes;
	setAttr -s 4 ".tk";
	setAttr ".tk[76]" -type "float3" 0 -0.089017451 0 ;
	setAttr ".tk[78]" -type "float3" 0 -0.089017451 0 ;
createNode deleteComponent -n "deleteComponent9";
	rename -uid "73E3A417-4AAC-70A7-410E-48B72B352DF4";
	setAttr ".dc" -type "componentList" 1 "f[22]";
createNode deleteComponent -n "deleteComponent10";
	rename -uid "0243CF40-4681-E314-19F4-E6967E2D02CF";
	setAttr ".dc" -type "componentList" 1 "f[20]";
createNode polyTweak -n "polyTweak14";
	rename -uid "37DE74C4-4727-2563-47B2-9ABD2FB0197F";
	setAttr ".uopa" yes;
	setAttr -s 17 ".tk";
	setAttr ".tk[61]" -type "float3" 0 -0.035828695 0 ;
	setAttr ".tk[62]" -type "float3" 0 -0.035828695 0 ;
	setAttr ".tk[63]" -type "float3" 0 -0.035828695 0 ;
	setAttr ".tk[64]" -type "float3" 0 -0.035828695 0 ;
	setAttr ".tk[66]" -type "float3" 0.043775532 -0.033445776 0 ;
	setAttr ".tk[67]" -type "float3" 0.043775532 0 0 ;
	setAttr ".tk[68]" -type "float3" 0.043775532 0 0 ;
	setAttr ".tk[69]" -type "float3" 0.043775532 -0.033445776 0 ;
	setAttr ".tk[75]" -type "float3" 0 -0.059010606 0 ;
	setAttr ".tk[76]" -type "float3" 0 0.032320034 0 ;
	setAttr ".tk[77]" -type "float3" 0 -0.059010606 0 ;
	setAttr ".tk[78]" -type "float3" 0 0.032320034 0 ;
createNode polySplit -n "polySplit19";
	rename -uid "4C4F1C24-4D54-B63B-D3B3-8691153E38E5";
	setAttr -s 2 ".v[0:1]" -type "float3"  0.5 0.032563999 0.142901 
		0.5 0.053812001 -0.156873;
	setAttr -s 4 ".e[0:3]"  0 6 6 0;
	setAttr -s 4 ".d[0:3]"  -2147483525 0 1 -2147483518;
	setAttr ".sma" 180;
	setAttr ".m2015" yes;
createNode polyExtrudeFace -n "polyExtrudeFace14";
	rename -uid "B0C6208D-4E82-2B3B-3C89-30B3D480BFDF";
	setAttr ".ics" -type "componentList" 1 "f[75]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" 4.6464043 4.3556085 -0.064919561 ;
	setAttr ".rs" 42490;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" 4.6464043135045534 2.1306307966540592 -1.4577907923554425 ;
	setAttr ".cbx" -type "double3" 4.6464043135045534 6.5805862574892213 1.3279516768390192 ;
createNode polyPlanarProj -n "polyPlanarProj1";
	rename -uid "60497944-47B5-6283-236D-4A9A7794C4D6";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[0:79]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".ws" yes;
	setAttr ".pc" -type "double3" 0.12302327156066895 8.6687443256378174 2.384185791015625e-07 ;
	setAttr ".ro" -type "double3" 0 90 0 ;
	setAttr ".ps" -type "double2" 10.695099353790283 17.357503414154053 ;
	setAttr ".cam" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
createNode polyTweak -n "polyTweak15";
	rename -uid "363EE8D8-44DE-E5D9-3B25-7EBF1DC6B011";
	setAttr ".uopa" yes;
	setAttr -s 5 ".tk";
	setAttr ".tk[13]" -type "float3" -0.10039852 0 0 ;
	setAttr ".tk[89]" -type "float3" -0.15696228 0.044035014 -0.21413724 ;
	setAttr ".tk[90]" -type "float3" -0.15696228 -0.044035025 -0.18362127 ;
	setAttr ".tk[91]" -type "float3" -0.15696228 0.038999245 0.21413724 ;
	setAttr ".tk[92]" -type "float3" -0.15696228 -0.044035025 0.20358293 ;
createNode polyAutoProj -n "polyAutoProj1";
	rename -uid "1ADE9029-4AB5-C2A1-90EE-84BDDC120F73";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[0:79]";
	setAttr ".ix" -type "matrix" 9.2928086270091068 0 0 0 0 11.974801385335542 0 0 0 0 9.2928086270091068 0
		 0 5.9361982345581525 0 1;
	setAttr ".s" -type "double3" 17.357503449406725 17.357503449406725 17.357503449406725 ;
	setAttr ".ps" 0.20000000298023224;
	setAttr ".dl" yes;
createNode polyMapCut -n "polyMapCut1";
	rename -uid "F7836674-480B-33F0-0459-B590CA05CB4C";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[59]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut2";
	rename -uid "B28325A8-41CC-4725-2F8F-D9B9BD0156FF";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[53]" "e[59:60]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut3";
	rename -uid "4D23E892-420C-7401-584E-06AE42EB8EA6";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[65]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut4";
	rename -uid "BEF1890A-43EA-8187-E5AE-829EB0263204";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[8]" "e[65:66]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut5";
	rename -uid "D5303F4F-45C6-B9FF-37C7-E1941FF27648";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[123]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut6";
	rename -uid "A866C8AA-47A7-2D05-C54E-43B34BFFB8F1";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[123]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut7";
	rename -uid "45B91C64-4DA0-5483-D43B-B89C9F01D593";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[79]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut8";
	rename -uid "2A1D4731-45A0-F146-F08B-CB89E08755A4";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[79]" "e[88]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut9";
	rename -uid "6FBA0D04-4218-64B3-1462-D59EBD8A5262";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[74]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut10";
	rename -uid "AB0E2202-4926-AC2F-4D37-119F50FA204C";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[74]" "e[82]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut11";
	rename -uid "AFCB4AA4-4373-99DC-2794-A28C0DCDB535";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[7]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut12";
	rename -uid "F0C604B5-4B86-AFA5-1E39-25A4DEA08474";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[7]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyTweakUV -n "polyTweakUV4";
	rename -uid "95DF1419-4AB5-8193-B5E9-8E99766C2E3B";
	setAttr ".uopa" yes;
	setAttr -s 241 ".uvtk[0:240]" -type "float2" -0.00078985095 -0.0013301373
		 -0.00067961216 -0.0010072589 -0.00056937337 -0.00068449974 -0.00045913458 -0.00036114454
		 -0.000238657 0.00028452277 -0.00012841821 0.00060787797 -1.8179417e-05 0.00093069673
		 9.2059374e-05 0.0012535453 0.016731769 -0.007258445 -0.00057795644 3.9845705e-05
		 0.0014783442 -0.00090557337 0.022583455 0.0066811144 -0.00064378977 6.2227249e-05
		 -0.00030595064 -0.00094491243 -0.0029065013 0.010513604 -0.0019444823 0.0089908838
		 2.5844201e-08 0 1.6763806e-08 -1.7881393e-07 1.0430813e-07 -1.7881393e-07 7.4505806e-09
		 -5.9604645e-08 9.0803951e-09 2.9802322e-07 -7.4505806e-09 5.9604645e-08 -2.9802322e-08
		 5.9604645e-08 -2.9802322e-08 1.7881393e-07 -2.9802322e-08 2.9802322e-07 -2.9802322e-08
		 -1.1920929e-07 -1.4901161e-08 1.1920929e-07 -1.4901161e-08 -2.3841858e-07 -1.4901161e-08
		 -1.7881393e-07 0 -5.9604645e-08 -0.0051879734 -0.0083002448 0.0034216344 -0.0021998882
		 0.0030298829 0.0053993464 -0.0076505542 -0.0021682382 0.004688412 0.0057946742 0.0079783499
		 0.0034495294 -0.0062797368 -0.0019752383 -0.016501889 0 0.015602335 0.0063805282
		 -0.014702752 0 0.015602306 -0.0063804984 8.9406967e-08 1.1920929e-07 0 0 -8.9406967e-08
		 -5.9604645e-08 -2.9802322e-08 -1.1920929e-07 8.7454915e-05 -0.00010854006 8.2120299e-05
		 0.0001116395 -3.2395124e-05 0.00011593103 -2.6702881e-05 -0.00011843443 3.0502677e-05
		 -0.00036877394 -0.00010424852 -0.00030821562 4.8428774e-05 0.00037187338 -8.5175037e-05
		 0.00030446053 -0.0004940927 -0.0013781786 -1.7553568e-05 0.001285553 0.00050935149
		 0.0014633536 2.2947788e-06 -0.001370728 -5.9604645e-08 0 0 0 0 0 5.9604645e-08 0
		 -1.1920929e-07 7.1525574e-07 1.1920929e-07 7.7486038e-07 5.9604645e-08 -7.1525574e-07
		 -1.1920929e-07 -7.7486038e-07 0 5.9604645e-08 0 5.9604645e-08 0 -5.9604645e-08 0
		 -5.9604645e-08 0 5.9604645e-08 0 5.9604645e-08 0 -5.9604645e-08 0 -5.9604645e-08
		 0 -3.5762787e-07 -1.1920929e-07 -4.1723251e-07 0 3.5762787e-07 1.1920929e-07 4.1723251e-07
		 2.3841858e-07 -8.3446503e-07 0 -8.3446503e-07 -2.3841858e-07 8.3446503e-07 0 8.3446503e-07
		 0 0 0 0 0 0 0 0 5.9604645e-08 -5.364418e-07 -1.1920929e-07 -5.364418e-07 -5.9604645e-08
		 5.364418e-07 5.9604645e-08 5.364418e-07 5.9604645e-08 1.1920929e-07 1.7881393e-07
		 -1.7881393e-07 -1.7881393e-07 5.9604645e-08 0 5.9604645e-08 0.0041972995 -0.012913823
		 -0.016679823 0.015982985 -0.0037676096 -0.0070404112 0.0060215592 0.0027992129 0.0087375641
		 0.0067402124 0.0014910102 -0.0055681467 1.3411045e-07 1.1920929e-07 1.1920929e-07
		 1.1920929e-07 1.4901161e-07 -5.9604645e-08 1.6391277e-07 0 -7.4505806e-08 -5.9604645e-08
		 5.9604645e-08 -5.9604645e-08 1.1920929e-07 5.9604645e-08 1.4901161e-07 1.1920929e-07
		 8.9406967e-08 0 -1.0430813e-07 1.7881393e-07 7.4505806e-08 -5.9604645e-08 2.9802322e-08
		 1.7881393e-07 1.937151e-07 5.9604645e-08 1.4901161e-07 0 2.0861626e-07 1.1920929e-07
		 1.6391277e-07 0 2.9802322e-08 5.9604645e-08 1.4901161e-08 0 -1.7881393e-07 0 -2.0861626e-07
		 0 -1.4901161e-08 -5.9604645e-08 -1.937151e-07 -1.1920929e-07 -2.9802322e-08 -5.9604645e-08
		 -2.2351742e-07 -1.1920929e-07 -4.4703484e-08 -5.9604645e-08 -5.9604645e-08 -1.1920929e-07
		 -1.4901161e-07 -5.9604645e-08 -8.9406967e-08 -5.9604645e-08 -8.9406967e-08 0 -1.6391277e-07
		 -5.9604645e-08 -1.0430813e-07 -5.9604645e-08 -1.1920929e-07 -5.9604645e-08 0.0061448812
		 0.013592061 0.0069312453 0.0014156401 0.0075863004 0.00091484189 0.0041617751 -0.012141386
		 -0.0049176812 -0.0003888011 -0.0053939223 -0.0010618269 0.0019746423 0.00070088729
		 0.0014815927 -0.0018312968 -0.0078787208 0.011787575 9.304285e-05 -0.0013385462 -0.0031697154
		 -0.00069443823 -0.0021868944 0.0017527714 -0.0065527558 0.0027593374 0.0059037805
		 -0.00039592385 5.9604645e-08 2.3841858e-07 2.9802322e-08 0 -2.9802322e-08 0 2.9802322e-08
		 2.3841858e-07 -2.9802322e-08 -2.3841858e-07 -5.9604645e-08 -2.3841858e-07 5.1259995e-06
		 0.00079452991 0.00066971779 -0.00037533045 -0.00039738417 -0.0017943978 -0.00027751923
		 0.0013751984 -0.0038644101 -0.0023972839 0.012858182 -0.0015387386 0.0028541386 -0.012653023
		 -0.0037505832 -0.001628086 -0.0046906397 0.0025746454 -0.013825119 0.0033171305 -5.1707029e-05
		 -0.006639123 -0.00080442429 -0.011658743 -0.0063078701 0.019789279 0.00070303679
		 0.018794984 0.0056574345 0.015068769 -0.002014637 0.0131547 -0.0017195344 0.012755647
		 0.0056624115 0.015877187 -0.0029221773 0.012764871 -0.0026270151 0.012365803 0.0004054904
		 0.0098827779 0.0068104267 0.012673914 -0.0041724443 -0.052076899 -0.0050799251 -0.052466732
		 -0.00021672249 -0.00097423792 -9.2744827e-05 0.00099223852 0.00021308661 0.0010074079
		 9.6440315e-05 -0.0010254383 -0.00031429529 -0.0010586381 -1.9073486e-06 0.00097420812
		 0.00030356646 0.0010255575 1.2636185e-05 -0.00094115734 9.9480152e-05 -0.00040608644
		 -6.5565109e-07 -0.00039374828 -9.9480152e-05 0.00040608644 6.5565109e-07 0.00039374828
		 -9.9420547e-05 0.00040602684 6.5565109e-07 0.00039374828 9.9420547e-05 -0.00040602684
		 -6.5565109e-07 -0.00039374828 0 -1.1920929e-07 0 -1.1920929e-07 0 1.1920929e-07 0
		 1.1920929e-07 0 5.9604645e-08 0 5.9604645e-08 0 -5.9604645e-08 0 -5.9604645e-08 -5.9604645e-08
		 2.3841858e-07 0 2.3841858e-07 2.9802322e-08 -2.3841858e-07 0 -2.3841858e-07 0 -2.3841858e-07
		 -5.9604645e-08 -2.3841858e-07 0 -2.9802322e-07 5.9604645e-08 7.1525574e-07 -9.6142292e-05
		 0.00038647652 6.5565109e-07 0.00037437677 9.6142292e-05 -0.00038647652 -6.5565109e-07
		 -0.00037437677 9.6023083e-05 -0.00038617849 -6.5565109e-07 -0.00037413836 -9.6023083e-05
		 0.00038617849 6.5565109e-07 0.00037413836 -0.0019516945 -0.0037184954 -0.0042398572
		 0.0057510138 0.0019984245 0.0048577785 0.0041931272 -0.0068903565 -0.0010257363 -3.0338764e-05
		 -0.00049558282 0.01584667 0.0015558898 0.015907288 0.0010257363 3.0338764e-05 -0.0015558898
		 -0.015907288 0.00049558282 -0.01584667 0.0053706169 0.0076884031 0.00090956688 -0.0035473704
		 -0.004912436 -0.0090905428 -0.0013677478 0.0049495697 0.00032711029 -0.0012628324
		 -0.00085097551 0.0033243513 0.0006493926 -0.0055087395 -0.0066338778 -0.014118096
		 0.0031633973 0.003026545 -0.00083261728 -0.00053211302 0.002384007 0.00098532438
		 0.00045642257 0.0010694861 -0.023326874 -0.0034843087 -0.011137336 -0.015442848 0.0036068261
		 -0.0076333731 0.013272583 -0.00032767653;
createNode polyMapCut -n "polyMapCut13";
	rename -uid "455FDA64-4391-49B1-FF2B-F7B282AE2AEA";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[5]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyMapCut -n "polyMapCut14";
	rename -uid "7492198A-4FBE-14C6-E293-68BCF6AA1357";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[5]";
	setAttr ".uic" yes;
	setAttr ".mr" 0.10000000149011612;
createNode polyTweakUV -n "polyTweakUV5";
	rename -uid "F323A63F-471F-A1CF-2DC1-48A9E927EFA5";
	setAttr ".uopa" yes;
	setAttr -s 243 ".uvtk[0:242]" -type "float2" -2.9802322e-08 5.9604645e-08
		 0 0 0 0 0 0 0 0 0 0 0 0 2.9802322e-08 -2.9802322e-08 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 -6.2864274e-09 0 -1.8626451e-09 -5.9604645e-08 0 0 0 0 1.6298145e-09 0 6.0535967e-09
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 -1.4901161e-08 0 -5.9604645e-08 -5.9604645e-08 7.4505806e-08
		 -8.9406967e-08 8.9406967e-08 2.9802322e-08 -8.9406967e-08 5.9604645e-08 5.9604645e-08
		 2.9802322e-08 0 2.9802322e-08 -5.9604645e-08 0 1.4901161e-08 0 0 0 0 0 -7.4505806e-09
		 0 0 0 0 0 0 0 0 0 1.4901161e-08 0 -1.4901161e-08 0 0 0 0 0 -2.9802322e-08 0 -2.9802322e-08
		 0 1.4901161e-08 -5.9604645e-08 0 0 0 -5.9604645e-08 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 -5.9604645e-08 0 -5.9604645e-08 0 5.9604645e-08 0 5.9604645e-08 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 5.9604645e-08 0 0 0 -5.9604645e-08 -5.9604645e-08 0 -5.9604645e-08
		 5.9604645e-08 5.9604645e-08 0 5.9604645e-08 -5.9604645e-08 0 0 0 0 0 0 0 0 -5.9604645e-08
		 0 -5.9604645e-08 0 5.9604645e-08 0 5.9604645e-08 0 0 0 0 0 0 0 0 0 0 0 0 2.9802322e-08
		 0 0 0 0 0 0 0 0 1.4901161e-08 0 1.4901161e-08 0 2.9802322e-08 0 2.9802322e-08 0 1.4901161e-08
		 5.9604645e-08 1.4901161e-08 0 2.9802322e-08 0 1.4901161e-08 0 1.4901161e-08 0 1.4901161e-08
		 0 1.4901161e-08 0 1.4901161e-08 -5.9604645e-08 2.9802322e-08 0 2.9802322e-08 0 2.9802322e-08
		 0 2.9802322e-08 0 -1.4901161e-08 0 -1.4901161e-08 0 0 0 0 0 -1.4901161e-08 0 -1.4901161e-08
		 0 -1.4901161e-08 0 -1.4901161e-08 0 -2.9802322e-08 0 -2.9802322e-08 0 -1.4901161e-08
		 0 -2.9802322e-08 0 -2.9802322e-08 0 -4.4703484e-08 0 -2.9802322e-08 0 -2.9802322e-08
		 0 0 2.2351742e-08 5.9604645e-08 2.9802322e-08 0 2.9802322e-08 0 1.6763806e-08 0 -2.9802322e-08
		 0 0 0 6.519258e-09 0 3.7252903e-09 0 -3.7252903e-08 0 -2.0489097e-08 -5.9604645e-08
		 -5.5879354e-09 0 -3.7252903e-09 0 -7.4505806e-09 0 7.4505806e-09 0 0 0 0 0 0 -2.9802322e-08
		 -5.9604645e-08 2.9802322e-08 5.9604645e-08 0 0 0 0 0 0 0 0 0 0 3.259629e-09 0 0 0
		 0 0 3.3760443e-09 0 3.7252903e-09 0 0 -1.8626451e-09 0 1.4901161e-08 0 0 0 0 0 0
		 -0.0052523017 0.0044524074 0.012803972 -0.0011310875 -0.0026940703 -0.0023551136
		 -0.0053035319 0.0041598678 -4.0531158e-05 -0.0012764186 -0.00035691261 -0.0019762367
		 -0.011152029 -0.0053860247 -0.0038043261 -0.0019567311 0.0031968355 0.0034225918
		 0.0022723675 0.0038404502 -5.9604645e-08 0 5.9604645e-08 0 1.1920929e-07 2.9802322e-08
		 -5.9604645e-08 -5.9604645e-08 -5.9604645e-08 -5.9604645e-08 0 2.9802322e-08 0 2.9802322e-08
		 0 0 5.9604645e-08 0 5.9604645e-08 0 -5.9604645e-08 0 -5.9604645e-08 0 5.9604645e-08
		 5.9604645e-08 5.9604645e-08 5.9604645e-08 -5.9604645e-08 -5.9604645e-08 -5.9604645e-08
		 -5.9604645e-08 0 -5.9604645e-08 0 -5.9604645e-08 0 5.9604645e-08 0 5.9604645e-08
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 -5.9604645e-08 -1.1920929e-07
		 -5.9604645e-08 -5.9604645e-08 5.9604645e-08 1.1920929e-07 5.9604645e-08 5.9604645e-08
		 0 0 0 0 0 0 0 0 0 0 -2.9802322e-08 0 -2.9802322e-08 5.9604645e-08 0 0 2.9802322e-08
		 -5.9604645e-08 2.9802322e-08 0 0 0 0 0 0 0 0 0 0 1.8626451e-08 0 2.0489097e-08 0
		 -1.8626451e-08 0 -3.9115548e-08 0 3.7252903e-09 0 -7.4505806e-09 2.9802322e-08 -2.9802322e-08
		 2.9802322e-08 0 -2.9802322e-08 0 0 0 2.9802322e-08 0 0 0 -0.0023777485 -0.0016552806
		 0.012708187 -0.00013841689;
createNode polyLayoutUV -n "polyLayoutUV1";
	rename -uid "931C3681-41B9-AADD-DA90-69ACD4ECFD77";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[0:79]";
	setAttr ".fr" no;
	setAttr ".l" 0;
	setAttr ".ps" 0.20000000298023224;
	setAttr ".sc" 0;
	setAttr ".dl" yes;
	setAttr ".rbf" 3;
	setAttr ".lm" 1;
createNode polyTweakUV -n "polyTweakUV6";
	rename -uid "B707DA47-4589-DF64-B4F1-F1BBB9CE9644";
	setAttr ".uopa" yes;
	setAttr -s 243 ".uvtk[0:242]" -type "float2" 0.41967982 0.023969769 0.41968012
		 0.019696057 0.41968039 0.015422344 0.41968074 0.011148691 0.41968134 0.0026012659
		 0.4196817 -0.0016724467 0.41968203 -0.0059461594 0.41968232 -0.010219842 -0.3326886
		 0.17520833 0.42271078 0.0068751872 0.42270944 0.024430335 -0.33527657 0.17601776
		 0.42357892 0.0068752468 0.42357779 0.021652937 -0.34904444 0.18818474 -0.34904462
		 0.18694103 0.60351777 -0.45171776 0.60351777 -0.46145272 0.6143046 -0.46122527 0.61495876
		 -0.4704546 0.60351771 -0.46979702 0.60351771 -0.479532 0.62553233 -0.48287702 0.62553233
		 -0.47856402 0.62553233 -0.47425094 0.62553233 -0.46993795 0.62553233 -0.46131188
		 0.62553233 -0.4569988 0.62553233 -0.4526858 0.62553233 -0.44837272 0.12992923 -0.29997906
		 0.12992933 -0.32707024 0.15153301 -0.3303282 0.15153283 -0.29672089 0.15245858 -0.3307808
		 0.15730396 -0.31352451 0.15245837 -0.29626828 0.49613586 0.11082226 0.49077353 0.093883067
		 0.50113147 0.11082226 0.49077356 0.12776142 -0.27613148 -0.29042256 -0.27613148 -0.30533624
		 -0.26430362 -0.30533624 -0.27613148 -0.32024997 0.015160978 -0.30052373 0.015160322
		 -0.30908778 0.01962024 -0.30936208 0.019620955 -0.30025011 0.015154034 -0.3191691
		 0.020641208 -0.32007778 0.015156224 -0.29044247 0.020643532 -0.28953457 -0.088682398
		 -0.28713733 -0.088678613 -0.31544918 -0.083175808 -0.31635413 -0.083179832 -0.28623092
		 -0.021236241 -0.59420222 -0.024196446 -0.59459269 -0.024199963 -0.6172846 -0.021239698
		 -0.61689413 -0.84190452 -0.093414009 -0.84229505 -0.096374154 -0.81960297 -0.096370757
		 -0.8192125 -0.093410552 0.28373724 -0.16153538 0.28082424 -0.16153538 0.28082424
		 -0.18473998 0.28373724 -0.18473998 0.19694251 -0.38386893 0.24766368 -0.38386893
		 0.24766368 0.02017355 0.19694251 0.02017355 0.1363883 0.073185205 0.13324642 0.073185205
		 0.13324642 0.049495637 0.1363883 0.049495637 0.043578446 -0.14851069 0.098361731
		 -0.14851081 0.098361969 0.26331332 0.043578744 0.26331344 -0.49216652 0.067090809
		 -0.48543078 0.11954868 -0.88083869 0.11949688 -0.88757449 0.067038953 0.0071635246
		 -0.80719888 0.059620976 -0.80046308 0.059672952 -0.40505782 0.0072152615 -0.41179344
		 -0.073138773 -0.20335841 -0.059051454 -0.20545375 -0.059069455 -0.18302429 -0.072423875
		 -0.18310565 -0.66791081 -0.28923857 -0.68718714 -0.32330373 -0.66791344 -0.32245633
		 -0.68535912 -0.29107633 -0.6486398 -0.32330674 -0.65046287 -0.29107907 0.67577529
		 -0.61310881 0.67169011 -0.61310881 0.67169011 -0.61742187 0.67577529 -0.61742181
		 0.67565989 -0.6125232 0.67268401 -0.6125232 0.6727767 -0.61805511 0.67566222 -0.61805511
		 0.67577529 -0.6087957 0.67565989 -0.60938132 0.67169011 -0.60879576 0.67268395 -0.60938132
		 0.67169011 -0.62173486 0.6727767 -0.62110156 0.67577529 -0.62173486 0.67566222 -0.62110156
		 0.67577529 -0.60016966 0.67169005 -0.60016966 0.67565519 -0.5994696 0.67289609 -0.5994696
		 0.67577529 -0.59585667 0.67565525 -0.59655666 0.67169011 -0.59585667 0.67289603 -0.59655666
		 0.67577529 -0.59154356 0.67169011 -0.59154356 0.67548245 -0.59088004 0.67265427 -0.59088004
		 0.67577529 -0.58723056 0.67548251 -0.58789414 0.67169011 -0.58723056 0.67265421 -0.58789414
		 -0.59700727 0.27710688 -0.59700972 0.30448946 -0.59826815 0.30579585 -0.59826517
		 0.2717118 -0.57063854 0.30449206 -0.5693804 0.30579871 -0.63505936 0.72903579 -0.039956331
		 -0.0077248365 -0.57063562 0.27710944 -0.61657345 0.73036909 -0.62654412 0.7290355
		 -0.62691474 0.7356618 -0.027005374 -0.0030783787 -0.045756757 -0.0030817688 0.52808082
		 -0.62173474 0.52808082 -0.60682106 0.52590412 -0.60682106 0.52590412 -0.62173474
		 0.52808082 -0.59190738 0.52590412 -0.59190738 -0.41597226 -0.17804718 -0.41588432
		 -0.16896045 -0.42084193 -0.1625368 -0.4208442 -0.18456537 0.30908275 0.3423146 0.34090835
		 0.34024781 0.6505875 0.040799066 0.30856231 0.34318838 0.31173757 0.32091227 0.33943155
		 0.31889004 0.65381753 0.038347453 0.65382063 0.040794969 0.65384299 0.058690846 0.65060985
		 0.058694839 -0.010483444 0.40546194 0.02135545 0.40348125 0.36861205 0.061056852
		 -0.0099219382 0.40628538 0.30715036 0.10757446 0.30715597 0.0610497 0.021171331 0.42737541
		 -0.006039381 0.4270609 0.36856663 0.44774961 0.30711055 0.4477424 0.16846275 0.049017429
		 0.16840804 0.014482707 0.17394888 0.014501512 0.17393768 0.050202906 0.21384001 -0.292189
		 0.21381265 -0.32789069 0.21935356 -0.32791206 0.21931446 -0.29337698 -0.013611913
		 0.020662725 -0.063365519 0.020655274 -0.063305438 -0.37854797 -0.013551831 -0.37854052
		 0.020967484 -0.56788874 0.070721209 -0.56788141 0.070661783 -0.16867805 0.020908058
		 -0.16868538 0.34028465 0.10854894 0.33752555 0.10854894 0.33752555 0.085344493 0.34028465
		 0.085344493 0.30294824 0.30524474 0.25490648 0.30524474 0.25490648 -0.098796606 0.30294824
		 -0.098796606 0.41053927 -0.389355 0.46182093 -0.38999784 0.46693802 0.018229961 0.41564089
		 0.017645538 0.40053612 0.018260479 0.34924674 0.018260479 0.34924662 -0.3888014 0.400536
		 -0.39002883 0.16617566 -0.37910241 0.21679449 -0.37909591 0.21674275 0.020447433
		 0.16612399 0.020440936 0.12967855 0.020447135 0.07905966 0.020440638 0.079110742
		 -0.37910295 0.12972969 -0.37909645 -0.46026063 -0.33545107 -0.46010497 -0.34509593
		 -0.45299298 -0.34607503 -0.45299217 -0.33413517 0.49127337 -0.18791717 0.49127334
		 -0.17106855 0.48934656 -0.17106855 0.48934653 -0.18791717 0.49127334 -0.2047658 0.48934656
		 -0.2047658 -0.044293344 -0.83720851 -0.054427385 -0.83677894 -0.056269884 -0.84387761
		 -0.043664038 -0.84387004 -0.6437574 0.73566234 -0.6450299 0.73036993 -0.61784565
		 0.73566157 -0.56937659 0.2717146 -0.63468832 0.7356621 -0.032235503 -0.007723473
		 0.42271212 -0.01067996 0.42358002 -0.0079024434 -0.3654049 0.17521414 -0.36281666
		 0.17602271 0.65058446 0.038351491 0.34111345 0.34321424 0.36860663 0.10758168 0.021332979
		 0.40639514;
createNode script -n "uiConfigurationScriptNode";
	rename -uid "CEFCB26E-401F-D124-534A-389B988640CA";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n"
		+ "            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n"
		+ "            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n"
		+ "            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n"
		+ "            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n"
		+ "            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n"
		+ "            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n"
		+ "            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n"
		+ "            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n"
		+ "            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n"
		+ "            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 3135\n            -height 1422\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"ToggledOutliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"ToggledOutliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n"
		+ "            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -isSet 0\n            -isSetMember 0\n"
		+ "            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            -renderFilterIndex 0\n            -selectionOrder \"chronological\" \n            -expandAttribute 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 0\n            -showReferenceMembers 0\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n"
		+ "            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"0\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 1\n"
		+ "                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n"
		+ "                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 1\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -showCurveNames 0\n"
		+ "                -showActiveCurveNames 0\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                -valueLinesToggle 1\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n"
		+ "                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 1\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n"
		+ "                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n"
		+ "                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"timeEditorPanel\" (localizedPanelLabel(\"Time Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Time Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n"
		+ "                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n"
		+ "                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" != $panelName) {\n"
		+ "\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n"
		+ "                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -highlightConnections 0\n                -copyConnectionsOnPaste 0\n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -activeTab -1\n                -editorMode \"default\" \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"shapePanel\" (localizedPanelLabel(\"Shape Editor\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tshapePanel -edit -l (localizedPanelLabel(\"Shape Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"posePanel\" (localizedPanelLabel(\"Pose Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tposePanel -edit -l (localizedPanelLabel(\"Pose Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"contentBrowserPanel\" (localizedPanelLabel(\"Content Browser\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Content Browser\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-userCreated false\n\t\t\t\t-defaultImage \"vacantCell.xP:/\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 3135\\n    -height 1422\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 3135\\n    -height 1422\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "048F62D0-405B-9DDC-90B8-0CAB7D44FB83";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "polyTweakUV6.out" "pCubeShape1.i";
connectAttr "polyTweakUV6.uvtk[0]" "pCubeShape1.uvst[0].uvtw";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "polyCube1.out" "polyTweakUV1.ip";
connectAttr "polyTweakUV1.out" "polyTweak1.ip";
connectAttr "polyTweak1.out" "polySplit1.ip";
connectAttr "polySplit1.out" "polyExtrudeFace1.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace1.mp";
connectAttr "polyExtrudeFace1.out" "polySplit2.ip";
connectAttr "polySplit2.out" "polySplit3.ip";
connectAttr "polySplit3.out" "polyExtrudeFace2.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace2.mp";
connectAttr "polyExtrudeFace2.out" "polyTweakUV2.ip";
connectAttr "polyTweak2.out" "polyMergeVert1.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert1.mp";
connectAttr "polyTweakUV2.out" "polyTweak2.ip";
connectAttr "polyMergeVert1.out" "polyTweakUV3.ip";
connectAttr "polyTweak3.out" "polyMergeVert2.ip";
connectAttr "pCubeShape1.wm" "polyMergeVert2.mp";
connectAttr "polyTweakUV3.out" "polyTweak3.ip";
connectAttr "polyMergeVert2.out" "polyTweak4.ip";
connectAttr "polyTweak4.out" "polySplit4.ip";
connectAttr "polySplit4.out" "polySplit5.ip";
connectAttr "polySplit5.out" "polySplit6.ip";
connectAttr "polySplit6.out" "polySplit7.ip";
connectAttr "polySplit7.out" "polySplit8.ip";
connectAttr "polySplit8.out" "polySplit9.ip";
connectAttr "polySplit9.out" "polySplit10.ip";
connectAttr "polySplit10.out" "polySplit11.ip";
connectAttr "polySplit11.out" "polySplit12.ip";
connectAttr "polySplit12.out" "deleteComponent1.ig";
connectAttr "deleteComponent1.og" "polySplit13.ip";
connectAttr "polySplit13.out" "polySplit14.ip";
connectAttr "polySplit14.out" "polyTweak5.ip";
connectAttr "polyTweak5.out" "polySplit15.ip";
connectAttr "polySplit15.out" "polyExtrudeFace3.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace3.mp";
connectAttr "polyTweak6.out" "polyExtrudeFace4.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace4.mp";
connectAttr "polyExtrudeFace3.out" "polyTweak6.ip";
connectAttr "polyTweak7.out" "polyExtrudeFace5.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace5.mp";
connectAttr "polyExtrudeFace4.out" "polyTweak7.ip";
connectAttr "polyExtrudeFace5.out" "polyTweak8.ip";
connectAttr "polyTweak8.out" "deleteComponent2.ig";
connectAttr "deleteComponent2.og" "polyExtrudeFace6.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace6.mp";
connectAttr "polyTweak9.out" "polyExtrudeFace7.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace7.mp";
connectAttr "polyExtrudeFace6.out" "polyTweak9.ip";
connectAttr "polyExtrudeFace7.out" "polyExtrudeFace8.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace8.mp";
connectAttr "polyTweak10.out" "polyExtrudeFace9.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace9.mp";
connectAttr "polyExtrudeFace8.out" "polyTweak10.ip";
connectAttr "polyExtrudeFace9.out" "deleteComponent3.ig";
connectAttr "deleteComponent3.og" "deleteComponent4.ig";
connectAttr "deleteComponent4.og" "polySplit16.ip";
connectAttr "polySplit16.out" "polySplit17.ip";
connectAttr "polySplit17.out" "polySplit18.ip";
connectAttr "polySplit18.out" "deleteComponent5.ig";
connectAttr "deleteComponent5.og" "deleteComponent6.ig";
connectAttr "deleteComponent6.og" "deleteComponent7.ig";
connectAttr "deleteComponent7.og" "deleteComponent8.ig";
connectAttr "deleteComponent8.og" "polyExtrudeFace10.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace10.mp";
connectAttr "polyTweak11.out" "polyExtrudeFace11.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace11.mp";
connectAttr "polyExtrudeFace10.out" "polyTweak11.ip";
connectAttr "polyExtrudeFace11.out" "polyExtrudeFace12.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace12.mp";
connectAttr "polyTweak12.out" "polyExtrudeFace13.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace13.mp";
connectAttr "polyExtrudeFace12.out" "polyTweak12.ip";
connectAttr "polyExtrudeFace13.out" "polyTweak13.ip";
connectAttr "polyTweak13.out" "deleteComponent9.ig";
connectAttr "deleteComponent9.og" "deleteComponent10.ig";
connectAttr "deleteComponent10.og" "polyTweak14.ip";
connectAttr "polyTweak14.out" "polySplit19.ip";
connectAttr "polySplit19.out" "polyExtrudeFace14.ip";
connectAttr "pCubeShape1.wm" "polyExtrudeFace14.mp";
connectAttr "polyTweak15.out" "polyPlanarProj1.ip";
connectAttr "pCubeShape1.wm" "polyPlanarProj1.mp";
connectAttr "polyExtrudeFace14.out" "polyTweak15.ip";
connectAttr "polyPlanarProj1.out" "polyAutoProj1.ip";
connectAttr "pCubeShape1.wm" "polyAutoProj1.mp";
connectAttr "polyAutoProj1.out" "polyMapCut1.ip";
connectAttr "polyMapCut1.out" "polyMapCut2.ip";
connectAttr "polyMapCut2.out" "polyMapCut3.ip";
connectAttr "polyMapCut3.out" "polyMapCut4.ip";
connectAttr "polyMapCut4.out" "polyMapCut5.ip";
connectAttr "polyMapCut5.out" "polyMapCut6.ip";
connectAttr "polyMapCut6.out" "polyMapCut7.ip";
connectAttr "polyMapCut7.out" "polyMapCut8.ip";
connectAttr "polyMapCut8.out" "polyMapCut9.ip";
connectAttr "polyMapCut9.out" "polyMapCut10.ip";
connectAttr "polyMapCut10.out" "polyMapCut11.ip";
connectAttr "polyMapCut11.out" "polyMapCut12.ip";
connectAttr "polyMapCut12.out" "polyTweakUV4.ip";
connectAttr "polyTweakUV4.out" "polyMapCut13.ip";
connectAttr "polyMapCut13.out" "polyMapCut14.ip";
connectAttr "polyMapCut14.out" "polyTweakUV5.ip";
connectAttr "polyTweakUV5.out" "polyLayoutUV1.ip";
connectAttr "polyLayoutUV1.out" "polyTweakUV6.ip";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
// End of Start-End.ma
