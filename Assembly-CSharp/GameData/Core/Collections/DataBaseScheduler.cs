using System;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.Core.Collections
{
	// Token: 0x0200023B RID: 571
	public static class DataBaseScheduler : Object
	{
		// Token: 0x0600476D RID: 18285 RVA: 0x00195E08 File Offset: 0x00194008
		// Note: this type is marked as 'beforefieldinit'.
		static DataBaseScheduler()
		{
			Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "DataBaseScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr);
			DataBaseScheduler.NativeFieldInfoPtr_allNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "allNodes");
			DataBaseScheduler.NativeFieldInfoPtr_newsNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "newsNodes");
			DataBaseScheduler.NativeFieldInfoPtr__CGDictionary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<CGDictionary>k__BackingField");
			DataBaseScheduler.NativeFieldInfoPtr__AllNodesMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<AllNodesMapping>k__BackingField");
			DataBaseScheduler.NativeFieldInfoPtr__NewsNodesMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<NewsNodesMapping>k__BackingField");
			DataBaseScheduler.NativeFieldInfoPtr__CGDictionaryMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<CGDictionaryMapping>k__BackingField");
			DataBaseScheduler.NativeFieldInfoPtr__DefaultSchedulerData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<DefaultSchedulerData>k__BackingField");
			DataBaseScheduler.NativeFieldInfoPtr__SchedulerConnectionData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<SchedulerConnectionData>k__BackingField");
			DataBaseScheduler.NativeFieldInfoPtr__SchedulerNewsData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<SchedulerNewsData>k__BackingField");
			DataBaseScheduler.NativeMethodInfoPtr_get_CGDictionary_Private_Static_get_Dictionary_2_String_CGPictureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677592);
			DataBaseScheduler.NativeMethodInfoPtr_set_CGDictionary_Private_Static_set_Void_Dictionary_2_String_CGPictureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677593);
			DataBaseScheduler.NativeMethodInfoPtr_get_AllNodesMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677594);
			DataBaseScheduler.NativeMethodInfoPtr_set_AllNodesMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677595);
			DataBaseScheduler.NativeMethodInfoPtr_get_NewsNodesMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677596);
			DataBaseScheduler.NativeMethodInfoPtr_set_NewsNodesMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677597);
			DataBaseScheduler.NativeMethodInfoPtr_get_CGDictionaryMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677598);
			DataBaseScheduler.NativeMethodInfoPtr_set_CGDictionaryMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677599);
			DataBaseScheduler.NativeMethodInfoPtr_get_DefaultSchedulerData_Public_Static_get_Dictionary_2_String_List_1_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677600);
			DataBaseScheduler.NativeMethodInfoPtr_set_DefaultSchedulerData_Private_Static_set_Void_Dictionary_2_String_List_1_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677601);
			DataBaseScheduler.NativeMethodInfoPtr_get_SchedulerConnectionData_Public_Static_get_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677602);
			DataBaseScheduler.NativeMethodInfoPtr_set_SchedulerConnectionData_Private_Static_set_Void_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677603);
			DataBaseScheduler.NativeMethodInfoPtr_get_SchedulerNewsData_Public_Static_get_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677604);
			DataBaseScheduler.NativeMethodInfoPtr_set_SchedulerNewsData_Private_Static_set_Void_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677605);
			DataBaseScheduler.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseSchedulerData_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677606);
			DataBaseScheduler.NativeMethodInfoPtr_GetAllNodes_Public_Static_IEnumerable_1_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677607);
			DataBaseScheduler.NativeMethodInfoPtr_GetAllNodesLabel_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677608);
			DataBaseScheduler.NativeMethodInfoPtr_TargetNodeExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677609);
			DataBaseScheduler.NativeMethodInfoPtr_RefNode_Public_Static_SchedulerNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677610);
			DataBaseScheduler.NativeMethodInfoPtr_RefEvent_Public_Static_EventNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677611);
			DataBaseScheduler.NativeMethodInfoPtr_RefMission_Public_Static_MissionNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677612);
			DataBaseScheduler.NativeMethodInfoPtr_RefNews_Public_Static_NewsNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677613);
			DataBaseScheduler.NativeMethodInfoPtr_IsNewsPresent_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677614);
			DataBaseScheduler.NativeMethodInfoPtr_RefCGPicture_Public_Static_CGPictureProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677615);
			DataBaseScheduler.NativeMethodInfoPtr_GetAllCGPicture_Public_Static_IEnumerable_1_CGPictureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677616);
			DataBaseScheduler.NativeMethodInfoPtr_IfThisMissionHaveCG_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677617);
			DataBaseScheduler.NativeMethodInfoPtr_GetAllLabels_Public_Static_IEnumerable_1_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677618);
			DataBaseScheduler.NativeMethodInfoPtr_GetAllNews_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677619);
			DataBaseScheduler.NativeMethodInfoPtr_GetSchedulerNodesDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677620);
			DataBaseScheduler.NativeMethodInfoPtr_GetNewsNodesDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677621);
			DataBaseScheduler.NativeMethodInfoPtr_GetCGDictionaryDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, 100677622);
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x00196158 File Offset: 0x00194358
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x0019618C File Offset: 0x0019438C
		public unsafe static Dictionary<string, CGProfile.CGPictureProperty> CGDictionary
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188884, XrefRangeEnd = 188886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_get_CGDictionary_Private_Static_get_Dictionary_2_String_CGPictureProperty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CGProfile.CGPictureProperty>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188886, XrefRangeEnd = 188890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_set_CGDictionary_Private_Static_set_Void_Dictionary_2_String_CGPictureProperty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x001961C4 File Offset: 0x001943C4
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x001961F8 File Offset: 0x001943F8
		public unsafe static Dictionary<string, string> AllNodesMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188890, XrefRangeEnd = 188892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_get_AllNodesMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188892, XrefRangeEnd = 188896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_set_AllNodesMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x00196230 File Offset: 0x00194430
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x00196264 File Offset: 0x00194464
		public unsafe static Dictionary<string, string> NewsNodesMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188896, XrefRangeEnd = 188898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_get_NewsNodesMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188898, XrefRangeEnd = 188902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_set_NewsNodesMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x0019629C File Offset: 0x0019449C
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x001962D0 File Offset: 0x001944D0
		public unsafe static Dictionary<string, string> CGDictionaryMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188902, XrefRangeEnd = 188904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_get_CGDictionaryMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188904, XrefRangeEnd = 188908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_set_CGDictionaryMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x00196308 File Offset: 0x00194508
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x0019633C File Offset: 0x0019453C
		public unsafe static Dictionary<string, List<SchedulerNode>> DefaultSchedulerData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188908, XrefRangeEnd = 188910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_get_DefaultSchedulerData_Public_Static_get_Dictionary_2_String_List_1_SchedulerNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<SchedulerNode>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188910, XrefRangeEnd = 188914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_set_DefaultSchedulerData_Private_Static_set_Void_Dictionary_2_String_List_1_SchedulerNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x00196374 File Offset: 0x00194574
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x001963A8 File Offset: 0x001945A8
		public unsafe static Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>> SchedulerConnectionData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188914, XrefRangeEnd = 188916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_get_SchedulerConnectionData_Public_Static_get_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188916, XrefRangeEnd = 188920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_set_SchedulerConnectionData_Private_Static_set_Void_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x001963E0 File Offset: 0x001945E0
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x00196414 File Offset: 0x00194614
		public unsafe static Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>> SchedulerNewsData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188920, XrefRangeEnd = 188922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_get_SchedulerNewsData_Public_Static_get_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188922, XrefRangeEnd = 188926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_set_SchedulerNewsData_Private_Static_set_Void_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x0019644C File Offset: 0x0019464C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189302, RefRangeEnd = 189303, XrefRangeStart = 188926, XrefRangeEnd = 189302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Dictionary<string, DataBaseScheduler.DataBaseSchedulerData> schedulerData, Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>> allDlcSchedulerNodeConnections, Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>> allDlcSchedulerNews)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(schedulerData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allDlcSchedulerNodeConnections);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allDlcSchedulerNews);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseSchedulerData_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x001964A8 File Offset: 0x001946A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189309, RefRangeEnd = 189313, XrefRangeStart = 189303, XrefRangeEnd = 189309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SchedulerNode> GetAllNodes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetAllNodes_Public_Static_IEnumerable_1_SchedulerNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SchedulerNode>>(intPtr3) : null;
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x001964DC File Offset: 0x001946DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189313, XrefRangeEnd = 189319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetAllNodesLabel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetAllNodesLabel_Public_Static_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x00196510 File Offset: 0x00194710
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189325, RefRangeEnd = 189328, XrefRangeStart = 189319, XrefRangeEnd = 189325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TargetNodeExists(this string nodeLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_TargetNodeExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x00196554 File Offset: 0x00194754
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 189333, RefRangeEnd = 189341, XrefRangeStart = 189328, XrefRangeEnd = 189333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SchedulerNode RefNode(this string nodeLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_RefNode_Public_Static_SchedulerNode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchedulerNode>(intPtr3) : null;
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x00196598 File Offset: 0x00194798
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 189349, RefRangeEnd = 189363, XrefRangeStart = 189341, XrefRangeEnd = 189349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventNode RefEvent(this string eventLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(eventLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_RefEvent_Public_Static_EventNode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventNode>(intPtr3) : null;
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x001965DC File Offset: 0x001947DC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 189371, RefRangeEnd = 189402, XrefRangeStart = 189363, XrefRangeEnd = 189371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MissionNode RefMission(this string missionLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(missionLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_RefMission_Public_Static_MissionNode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MissionNode>(intPtr3) : null;
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00196620 File Offset: 0x00194820
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 189407, RefRangeEnd = 189412, XrefRangeStart = 189402, XrefRangeEnd = 189407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NewsNode RefNews(this string newLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_RefNews_Public_Static_NewsNode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewsNode>(intPtr3) : null;
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x00196664 File Offset: 0x00194864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189418, RefRangeEnd = 189420, XrefRangeStart = 189412, XrefRangeEnd = 189418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNewsPresent(this string newLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_IsNewsPresent_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x001966A8 File Offset: 0x001948A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189425, RefRangeEnd = 189427, XrefRangeStart = 189420, XrefRangeEnd = 189425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CGProfile.CGPictureProperty RefCGPicture(this string cgLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cgLabel);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_RefCGPicture_Public_Static_CGPictureProperty_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CGProfile.CGPictureProperty(pointer);
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x001966E4 File Offset: 0x001948E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189433, RefRangeEnd = 189434, XrefRangeStart = 189427, XrefRangeEnd = 189433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<CGProfile.CGPictureProperty> GetAllCGPicture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetAllCGPicture_Public_Static_IEnumerable_1_CGPictureProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CGProfile.CGPictureProperty>>(intPtr3) : null;
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00196718 File Offset: 0x00194918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189440, RefRangeEnd = 189441, XrefRangeStart = 189434, XrefRangeEnd = 189440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IfThisMissionHaveCG(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_IfThisMissionHaveCG_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x0019675C File Offset: 0x0019495C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189462, RefRangeEnd = 189466, XrefRangeStart = 189441, XrefRangeEnd = 189462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>> GetAllLabels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetAllLabels_Public_Static_IEnumerable_1_ValueTuple_4_NodeType_SchedulerType_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>>>(intPtr3) : null;
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00196790 File Offset: 0x00194990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189472, RefRangeEnd = 189474, XrefRangeStart = 189466, XrefRangeEnd = 189472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetAllNews()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetAllNews_Public_Static_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x001967C4 File Offset: 0x001949C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189481, RefRangeEnd = 189485, XrefRangeStart = 189474, XrefRangeEnd = 189481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSchedulerNodesDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetSchedulerNodesDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00196800 File Offset: 0x00194A00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189492, RefRangeEnd = 189494, XrefRangeStart = 189485, XrefRangeEnd = 189492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNewsNodesDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetNewsNodesDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x0019683C File Offset: 0x00194A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189494, XrefRangeEnd = 189501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCGDictionaryDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.NativeMethodInfoPtr_GetCGDictionaryDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x00024D83 File Offset: 0x00022F83
		public DataBaseScheduler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x00196878 File Offset: 0x00194A78
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x00024D8C File Offset: 0x00022F8C
		public unsafe static Dictionary<string, SchedulerNode> allNodes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr_allNodes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr_allNodes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x001968A0 File Offset: 0x00194AA0
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x00024D9E File Offset: 0x00022F9E
		public unsafe static Dictionary<string, NewsNode> newsNodes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr_newsNodes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NewsNode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr_newsNodes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x001968C8 File Offset: 0x00194AC8
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x00024DB0 File Offset: 0x00022FB0
		public unsafe static Dictionary<string, CGProfile.CGPictureProperty> _CGDictionary_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr__CGDictionary_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CGProfile.CGPictureProperty>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr__CGDictionary_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x001968F0 File Offset: 0x00194AF0
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x00024DC2 File Offset: 0x00022FC2
		public unsafe static Dictionary<string, string> _AllNodesMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr__AllNodesMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr__AllNodesMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x00196918 File Offset: 0x00194B18
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x00024DD4 File Offset: 0x00022FD4
		public unsafe static Dictionary<string, string> _NewsNodesMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr__NewsNodesMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr__NewsNodesMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x00196940 File Offset: 0x00194B40
		// (set) Token: 0x06004799 RID: 18329 RVA: 0x00024DE6 File Offset: 0x00022FE6
		public unsafe static Dictionary<string, string> _CGDictionaryMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr__CGDictionaryMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr__CGDictionaryMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x00196968 File Offset: 0x00194B68
		// (set) Token: 0x0600479B RID: 18331 RVA: 0x00024DF8 File Offset: 0x00022FF8
		public unsafe static Dictionary<string, List<SchedulerNode>> _DefaultSchedulerData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr__DefaultSchedulerData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<SchedulerNode>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr__DefaultSchedulerData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x00196990 File Offset: 0x00194B90
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x00024E0A File Offset: 0x0002300A
		public unsafe static Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>> _SchedulerConnectionData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr__SchedulerConnectionData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr__SchedulerConnectionData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x0600479E RID: 18334 RVA: 0x001969B8 File Offset: 0x00194BB8
		// (set) Token: 0x0600479F RID: 18335 RVA: 0x00024E1C File Offset: 0x0002301C
		public unsafe static Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>> _SchedulerNewsData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.NativeFieldInfoPtr__SchedulerNewsData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.NativeFieldInfoPtr__SchedulerNewsData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeFieldInfoPtr_allNodes;

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeFieldInfoPtr_newsNodes;

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeFieldInfoPtr__CGDictionary_k__BackingField;

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeFieldInfoPtr__AllNodesMapping_k__BackingField;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeFieldInfoPtr__NewsNodesMapping_k__BackingField;

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeFieldInfoPtr__CGDictionaryMapping_k__BackingField;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeFieldInfoPtr__DefaultSchedulerData_k__BackingField;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeFieldInfoPtr__SchedulerConnectionData_k__BackingField;

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeFieldInfoPtr__SchedulerNewsData_k__BackingField;

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeMethodInfoPtr_get_CGDictionary_Private_Static_get_Dictionary_2_String_CGPictureProperty_0;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeMethodInfoPtr_set_CGDictionary_Private_Static_set_Void_Dictionary_2_String_CGPictureProperty_0;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeMethodInfoPtr_get_AllNodesMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeMethodInfoPtr_set_AllNodesMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeMethodInfoPtr_get_NewsNodesMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeMethodInfoPtr_set_NewsNodesMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeMethodInfoPtr_get_CGDictionaryMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeMethodInfoPtr_set_CGDictionaryMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSchedulerData_Public_Static_get_Dictionary_2_String_List_1_SchedulerNode_0;

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultSchedulerData_Private_Static_set_Void_Dictionary_2_String_List_1_SchedulerNode_0;

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeMethodInfoPtr_get_SchedulerConnectionData_Public_Static_get_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeMethodInfoPtr_set_SchedulerConnectionData_Private_Static_set_Void_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeMethodInfoPtr_get_SchedulerNewsData_Public_Static_get_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0;

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeMethodInfoPtr_set_SchedulerNewsData_Private_Static_set_Void_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseSchedulerData_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_Dictionary_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNodes_Public_Static_IEnumerable_1_SchedulerNode_0;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNodesLabel_Public_Static_IEnumerable_1_String_0;

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeMethodInfoPtr_TargetNodeExists_Public_Static_Boolean_String_0;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeMethodInfoPtr_RefNode_Public_Static_SchedulerNode_String_0;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeMethodInfoPtr_RefEvent_Public_Static_EventNode_String_0;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeMethodInfoPtr_RefMission_Public_Static_MissionNode_String_0;

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeMethodInfoPtr_RefNews_Public_Static_NewsNode_String_0;

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeMethodInfoPtr_IsNewsPresent_Public_Static_Boolean_String_0;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeMethodInfoPtr_RefCGPicture_Public_Static_CGPictureProperty_String_0;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCGPicture_Public_Static_IEnumerable_1_CGPictureProperty_0;

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeMethodInfoPtr_IfThisMissionHaveCG_Public_Static_Boolean_String_0;

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeMethodInfoPtr_GetAllLabels_Public_Static_IEnumerable_1_ValueTuple_4_NodeType_SchedulerType_String_String_0;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNews_Public_Static_IEnumerable_1_String_0;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeMethodInfoPtr_GetSchedulerNodesDLCMapping_Public_Static_String_String_0;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeMethodInfoPtr_GetNewsNodesDLCMapping_Public_Static_String_String_0;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeMethodInfoPtr_GetCGDictionaryDLCMapping_Public_Static_String_String_0;

		// Token: 0x02000AB1 RID: 2737
		public class DataBaseSchedulerData : Object
		{
			// Token: 0x0600CD7E RID: 52606 RVA: 0x0032ABF0 File Offset: 0x00328DF0
			// Note: this type is marked as 'beforefieldinit'.
			static DataBaseSchedulerData()
			{
				Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "DataBaseSchedulerData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr);
				DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__AllNodes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, "<AllNodes>k__BackingField");
				DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__NewsNodes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, "<NewsNodes>k__BackingField");
				DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__CGDictionary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, "<CGDictionary>k__BackingField");
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_SchedulerNode_Dictionary_2_String_NewsNode_Dictionary_2_String_CGPictureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677623);
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_get_AllNodes_Internal_get_Dictionary_2_String_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677624);
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_set_AllNodes_Internal_set_Void_Dictionary_2_String_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677625);
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_get_NewsNodes_Internal_get_Dictionary_2_String_NewsNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677626);
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_set_NewsNodes_Internal_set_Void_Dictionary_2_String_NewsNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677627);
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_get_CGDictionary_Internal_get_Dictionary_2_String_CGPictureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677628);
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_set_CGDictionary_Internal_set_Void_Dictionary_2_String_CGPictureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677629);
				DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_Method_Internal_Static_SchedulerNode_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, 100677630);
			}

			// Token: 0x0600CD7F RID: 52607 RVA: 0x0032ACF8 File Offset: 0x00328EF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 188873, RefRangeEnd = 188874, XrefRangeStart = 188836, XrefRangeEnd = 188873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataBaseSchedulerData(Dictionary<string, SchedulerNode> allNodes, Dictionary<string, NewsNode> newsNodes, Dictionary<string, CGProfile.CGPictureProperty> cGDictionary) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allNodes);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newsNodes);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cGDictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_SchedulerNode_Dictionary_2_String_NewsNode_Dictionary_2_String_CGPictureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042D0 RID: 17104
			// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x0032AD68 File Offset: 0x00328F68
			// (set) Token: 0x0600CD81 RID: 52609 RVA: 0x0032ADA8 File Offset: 0x00328FA8
			public unsafe Dictionary<string, SchedulerNode> AllNodes
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_get_AllNodes_Internal_get_Dictionary_2_String_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode>>(intPtr3) : null;
				}
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_set_AllNodes_Internal_set_Void_Dictionary_2_String_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170042D1 RID: 17105
			// (get) Token: 0x0600CD82 RID: 52610 RVA: 0x0032ADEC File Offset: 0x00328FEC
			// (set) Token: 0x0600CD83 RID: 52611 RVA: 0x0032AE2C File Offset: 0x0032902C
			public unsafe Dictionary<string, NewsNode> NewsNodes
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_get_NewsNodes_Internal_get_Dictionary_2_String_NewsNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NewsNode>>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_set_NewsNodes_Internal_set_Void_Dictionary_2_String_NewsNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170042D2 RID: 17106
			// (get) Token: 0x0600CD84 RID: 52612 RVA: 0x0032AE70 File Offset: 0x00329070
			// (set) Token: 0x0600CD85 RID: 52613 RVA: 0x0032AEB0 File Offset: 0x003290B0
			public unsafe Dictionary<string, CGProfile.CGPictureProperty> CGDictionary
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_get_CGDictionary_Internal_get_Dictionary_2_String_CGPictureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CGProfile.CGPictureProperty>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_set_CGDictionary_Internal_set_Void_Dictionary_2_String_CGPictureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CD86 RID: 52614 RVA: 0x0032AEF4 File Offset: 0x003290F4
			[CallerCount(1101)]
			[CachedScanResults(RefRangeStart = 161948, RefRangeEnd = 163049, XrefRangeStart = 161948, XrefRangeEnd = 163049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static SchedulerNode Method_Internal_Static_SchedulerNode_SchedulerNode_0(SchedulerNode node)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.NativeMethodInfoPtr_Method_Internal_Static_SchedulerNode_SchedulerNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchedulerNode>(intPtr3) : null;
			}

			// Token: 0x0600CD87 RID: 52615 RVA: 0x0006E1FE File Offset: 0x0006C3FE
			public DataBaseSchedulerData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042CD RID: 17101
			// (get) Token: 0x0600CD88 RID: 52616 RVA: 0x0032AF38 File Offset: 0x00329138
			// (set) Token: 0x0600CD89 RID: 52617 RVA: 0x0006E207 File Offset: 0x0006C407
			public unsafe Dictionary<string, SchedulerNode> _AllNodes_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__AllNodes_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__AllNodes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042CE RID: 17102
			// (get) Token: 0x0600CD8A RID: 52618 RVA: 0x0032AF68 File Offset: 0x00329168
			// (set) Token: 0x0600CD8B RID: 52619 RVA: 0x0006E226 File Offset: 0x0006C426
			public unsafe Dictionary<string, NewsNode> _NewsNodes_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__NewsNodes_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NewsNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__NewsNodes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042CF RID: 17103
			// (get) Token: 0x0600CD8C RID: 52620 RVA: 0x0032AF98 File Offset: 0x00329198
			// (set) Token: 0x0600CD8D RID: 52621 RVA: 0x0006E245 File Offset: 0x0006C445
			public unsafe Dictionary<string, CGProfile.CGPictureProperty> _CGDictionary_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__CGDictionary_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CGProfile.CGPictureProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseScheduler.DataBaseSchedulerData.NativeFieldInfoPtr__CGDictionary_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400840F RID: 33807
			private static readonly IntPtr NativeFieldInfoPtr__AllNodes_k__BackingField;

			// Token: 0x04008410 RID: 33808
			private static readonly IntPtr NativeFieldInfoPtr__NewsNodes_k__BackingField;

			// Token: 0x04008411 RID: 33809
			private static readonly IntPtr NativeFieldInfoPtr__CGDictionary_k__BackingField;

			// Token: 0x04008412 RID: 33810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_SchedulerNode_Dictionary_2_String_NewsNode_Dictionary_2_String_CGPictureProperty_0;

			// Token: 0x04008413 RID: 33811
			private static readonly IntPtr NativeMethodInfoPtr_get_AllNodes_Internal_get_Dictionary_2_String_SchedulerNode_0;

			// Token: 0x04008414 RID: 33812
			private static readonly IntPtr NativeMethodInfoPtr_set_AllNodes_Internal_set_Void_Dictionary_2_String_SchedulerNode_0;

			// Token: 0x04008415 RID: 33813
			private static readonly IntPtr NativeMethodInfoPtr_get_NewsNodes_Internal_get_Dictionary_2_String_NewsNode_0;

			// Token: 0x04008416 RID: 33814
			private static readonly IntPtr NativeMethodInfoPtr_set_NewsNodes_Internal_set_Void_Dictionary_2_String_NewsNode_0;

			// Token: 0x04008417 RID: 33815
			private static readonly IntPtr NativeMethodInfoPtr_get_CGDictionary_Internal_get_Dictionary_2_String_CGPictureProperty_0;

			// Token: 0x04008418 RID: 33816
			private static readonly IntPtr NativeMethodInfoPtr_set_CGDictionary_Internal_set_Void_Dictionary_2_String_CGPictureProperty_0;

			// Token: 0x04008419 RID: 33817
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_SchedulerNode_SchedulerNode_0;

			// Token: 0x02001015 RID: 4117
			[ObfuscatedName("GameData.Core.Collections.DataBaseScheduler+DataBaseSchedulerData+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06011A0B RID: 72203 RVA: 0x0040AC84 File Offset: 0x00408E84
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr);
					DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr, "<>9");
					DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr, "<>9__0_1");
					DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr, "<>9__0_2");
					DataBaseScheduler.DataBaseSchedulerData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr, 100677632);
					DataBaseScheduler.DataBaseSchedulerData.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_String_KeyValuePair_2_String_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr, 100677633);
					DataBaseScheduler.DataBaseSchedulerData.__c.NativeMethodInfoPtr___ctor_b__0_2_Internal_SchedulerNode_KeyValuePair_2_String_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr, 100677634);
				}

				// Token: 0x06011A0C RID: 72204 RVA: 0x0040AD28 File Offset: 0x00408F28
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseScheduler.DataBaseSchedulerData.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A0D RID: 72205 RVA: 0x0040AD64 File Offset: 0x00408F64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188834, XrefRangeEnd = 188835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string __ctor_b__0_1(KeyValuePair<string, SchedulerNode> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_String_KeyValuePair_2_String_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011A0E RID: 72206 RVA: 0x0040ADB4 File Offset: 0x00408FB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188835, XrefRangeEnd = 188836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SchedulerNode __ctor_b__0_2(KeyValuePair<string, SchedulerNode> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.DataBaseSchedulerData.__c.NativeMethodInfoPtr___ctor_b__0_2_Internal_SchedulerNode_KeyValuePair_2_String_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchedulerNode>(intPtr3) : null;
				}

				// Token: 0x06011A0F RID: 72207 RVA: 0x00099417 File Offset: 0x00097617
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BAC RID: 23468
				// (get) Token: 0x06011A10 RID: 72208 RVA: 0x0040AE0C File Offset: 0x0040900C
				// (set) Token: 0x06011A11 RID: 72209 RVA: 0x00099420 File Offset: 0x00097620
				public unsafe static DataBaseScheduler.DataBaseSchedulerData.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseScheduler.DataBaseSchedulerData.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BAD RID: 23469
				// (get) Token: 0x06011A12 RID: 72210 RVA: 0x0040AE34 File Offset: 0x00409034
				// (set) Token: 0x06011A13 RID: 72211 RVA: 0x00099432 File Offset: 0x00097632
				public unsafe static Func<KeyValuePair<string, SchedulerNode>, string> __9__0_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, SchedulerNode>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BAE RID: 23470
				// (get) Token: 0x06011A14 RID: 72212 RVA: 0x0040AE5C File Offset: 0x0040905C
				// (set) Token: 0x06011A15 RID: 72213 RVA: 0x00099444 File Offset: 0x00097644
				public unsafe static Func<KeyValuePair<string, SchedulerNode>, SchedulerNode> __9__0_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, SchedulerNode>, SchedulerNode>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.DataBaseSchedulerData.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B231 RID: 45617
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B232 RID: 45618
				private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

				// Token: 0x0400B233 RID: 45619
				private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

				// Token: 0x0400B234 RID: 45620
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B235 RID: 45621
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_1_Internal_String_KeyValuePair_2_String_SchedulerNode_0;

				// Token: 0x0400B236 RID: 45622
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_2_Internal_SchedulerNode_KeyValuePair_2_String_SchedulerNode_0;
			}
		}

		// Token: 0x02000AB2 RID: 2738
		[ObfuscatedName("GameData.Core.Collections.DataBaseScheduler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CD8E RID: 52622 RVA: 0x0032AFC8 File Offset: 0x003291C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseScheduler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr);
				DataBaseScheduler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_0");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_1");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_2");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_3");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_4");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_5");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_6");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__30_7");
				DataBaseScheduler.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, "<>9__42_0");
				DataBaseScheduler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677636);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_0_Internal_Dictionary_2_String_SchedulerNode_DataBaseSchedulerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677637);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_1_Internal_Dictionary_2_String_NewsNode_DataBaseSchedulerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677638);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_2_Internal_Dictionary_2_String_CGPictureProperty_DataBaseSchedulerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677639);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_3_Internal_Dictionary_2_String_SchedulerNode_DataBaseSchedulerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677640);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_4_Internal_Dictionary_2_String_NewsNode_DataBaseSchedulerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677641);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_5_Internal_Dictionary_2_String_CGPictureProperty_DataBaseSchedulerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677642);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_6_Internal_IEnumerable_1_SchedulerConnectionData_KeyValuePair_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677643);
				DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_7_Internal_IEnumerable_1_SchedulerNewsData_KeyValuePair_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677644);
				DataBaseScheduler.__c.NativeMethodInfoPtr__GetAllLabels_b__42_0_Internal_ValueTuple_4_NodeType_SchedulerType_String_String_KeyValuePair_2_String_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr, 100677645);
			}

			// Token: 0x0600CD8F RID: 52623 RVA: 0x0032B184 File Offset: 0x00329384
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseScheduler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD90 RID: 52624 RVA: 0x0032B1C0 File Offset: 0x003293C0
			[CallerCount(0)]
			public unsafe Dictionary<string, SchedulerNode> _Initialize_b__30_0(DataBaseScheduler.DataBaseSchedulerData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_0_Internal_Dictionary_2_String_SchedulerNode_DataBaseSchedulerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode>>(intPtr3) : null;
			}

			// Token: 0x0600CD91 RID: 52625 RVA: 0x0032B210 File Offset: 0x00329410
			[CallerCount(0)]
			public unsafe Dictionary<string, NewsNode> _Initialize_b__30_1(DataBaseScheduler.DataBaseSchedulerData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_1_Internal_Dictionary_2_String_NewsNode_DataBaseSchedulerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NewsNode>>(intPtr3) : null;
			}

			// Token: 0x0600CD92 RID: 52626 RVA: 0x0032B260 File Offset: 0x00329460
			[CallerCount(0)]
			public unsafe Dictionary<string, CGProfile.CGPictureProperty> _Initialize_b__30_2(DataBaseScheduler.DataBaseSchedulerData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_2_Internal_Dictionary_2_String_CGPictureProperty_DataBaseSchedulerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CGProfile.CGPictureProperty>>(intPtr3) : null;
			}

			// Token: 0x0600CD93 RID: 52627 RVA: 0x0032B2B0 File Offset: 0x003294B0
			[CallerCount(0)]
			public unsafe Dictionary<string, SchedulerNode> _Initialize_b__30_3(DataBaseScheduler.DataBaseSchedulerData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_3_Internal_Dictionary_2_String_SchedulerNode_DataBaseSchedulerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchedulerNode>>(intPtr3) : null;
			}

			// Token: 0x0600CD94 RID: 52628 RVA: 0x0032B300 File Offset: 0x00329500
			[CallerCount(0)]
			public unsafe Dictionary<string, NewsNode> _Initialize_b__30_4(DataBaseScheduler.DataBaseSchedulerData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_4_Internal_Dictionary_2_String_NewsNode_DataBaseSchedulerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NewsNode>>(intPtr3) : null;
			}

			// Token: 0x0600CD95 RID: 52629 RVA: 0x0032B350 File Offset: 0x00329550
			[CallerCount(0)]
			public unsafe Dictionary<string, CGProfile.CGPictureProperty> _Initialize_b__30_5(DataBaseScheduler.DataBaseSchedulerData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_5_Internal_Dictionary_2_String_CGPictureProperty_DataBaseSchedulerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CGProfile.CGPictureProperty>>(intPtr3) : null;
			}

			// Token: 0x0600CD96 RID: 52630 RVA: 0x0032B3A0 File Offset: 0x003295A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188874, XrefRangeEnd = 188875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ExpandableGameDataPack.SchedulerConnectionData> _Initialize_b__30_6(KeyValuePair<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_6_Internal_IEnumerable_1_SchedulerConnectionData_KeyValuePair_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ExpandableGameDataPack.SchedulerConnectionData>>(intPtr3) : null;
			}

			// Token: 0x0600CD97 RID: 52631 RVA: 0x0032B3F8 File Offset: 0x003295F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188875, XrefRangeEnd = 188876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ExpandableGameDataPack.SchedulerNewsData> _Initialize_b__30_7(KeyValuePair<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__Initialize_b__30_7_Internal_IEnumerable_1_SchedulerNewsData_KeyValuePair_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ExpandableGameDataPack.SchedulerNewsData>>(intPtr3) : null;
			}

			// Token: 0x0600CD98 RID: 52632 RVA: 0x0032B450 File Offset: 0x00329650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188876, XrefRangeEnd = 188884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> _GetAllLabels_b__42_0(KeyValuePair<string, SchedulerNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseScheduler.__c.NativeMethodInfoPtr__GetAllLabels_b__42_0_Internal_ValueTuple_4_NodeType_SchedulerType_String_String_KeyValuePair_2_String_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>(pointer);
			}

			// Token: 0x0600CD99 RID: 52633 RVA: 0x0006E264 File Offset: 0x0006C464
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D3 RID: 17107
			// (get) Token: 0x0600CD9A RID: 52634 RVA: 0x0032B4A0 File Offset: 0x003296A0
			// (set) Token: 0x0600CD9B RID: 52635 RVA: 0x0006E26D File Offset: 0x0006C46D
			public unsafe static DataBaseScheduler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseScheduler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D4 RID: 17108
			// (get) Token: 0x0600CD9C RID: 52636 RVA: 0x0032B4C8 File Offset: 0x003296C8
			// (set) Token: 0x0600CD9D RID: 52637 RVA: 0x0006E27F File Offset: 0x0006C47F
			public unsafe static Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, SchedulerNode>> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, SchedulerNode>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D5 RID: 17109
			// (get) Token: 0x0600CD9E RID: 52638 RVA: 0x0032B4F0 File Offset: 0x003296F0
			// (set) Token: 0x0600CD9F RID: 52639 RVA: 0x0006E291 File Offset: 0x0006C491
			public unsafe static Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, NewsNode>> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, NewsNode>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D6 RID: 17110
			// (get) Token: 0x0600CDA0 RID: 52640 RVA: 0x0032B518 File Offset: 0x00329718
			// (set) Token: 0x0600CDA1 RID: 52641 RVA: 0x0006E2A3 File Offset: 0x0006C4A3
			public unsafe static Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, CGProfile.CGPictureProperty>> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, CGProfile.CGPictureProperty>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D7 RID: 17111
			// (get) Token: 0x0600CDA2 RID: 52642 RVA: 0x0032B540 File Offset: 0x00329740
			// (set) Token: 0x0600CDA3 RID: 52643 RVA: 0x0006E2B5 File Offset: 0x0006C4B5
			public unsafe static Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, SchedulerNode>> __9__30_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, SchedulerNode>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D8 RID: 17112
			// (get) Token: 0x0600CDA4 RID: 52644 RVA: 0x0032B568 File Offset: 0x00329768
			// (set) Token: 0x0600CDA5 RID: 52645 RVA: 0x0006E2C7 File Offset: 0x0006C4C7
			public unsafe static Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, NewsNode>> __9__30_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, NewsNode>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D9 RID: 17113
			// (get) Token: 0x0600CDA6 RID: 52646 RVA: 0x0032B590 File Offset: 0x00329790
			// (set) Token: 0x0600CDA7 RID: 52647 RVA: 0x0006E2D9 File Offset: 0x0006C4D9
			public unsafe static Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, CGProfile.CGPictureProperty>> __9__30_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseScheduler.DataBaseSchedulerData, Dictionary<string, CGProfile.CGPictureProperty>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DA RID: 17114
			// (get) Token: 0x0600CDA8 RID: 52648 RVA: 0x0032B5B8 File Offset: 0x003297B8
			// (set) Token: 0x0600CDA9 RID: 52649 RVA: 0x0006E2EB File Offset: 0x0006C4EB
			public unsafe static Func<KeyValuePair<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>>, IEnumerable<ExpandableGameDataPack.SchedulerConnectionData>> __9__30_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerConnectionData>>, IEnumerable<ExpandableGameDataPack.SchedulerConnectionData>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DB RID: 17115
			// (get) Token: 0x0600CDAA RID: 52650 RVA: 0x0032B5E0 File Offset: 0x003297E0
			// (set) Token: 0x0600CDAB RID: 52651 RVA: 0x0006E2FD File Offset: 0x0006C4FD
			public unsafe static Func<KeyValuePair<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>>, IEnumerable<ExpandableGameDataPack.SchedulerNewsData>> __9__30_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Il2CppReferenceArray<ExpandableGameDataPack.SchedulerNewsData>>, IEnumerable<ExpandableGameDataPack.SchedulerNewsData>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__30_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DC RID: 17116
			// (get) Token: 0x0600CDAC RID: 52652 RVA: 0x0032B608 File Offset: 0x00329808
			// (set) Token: 0x0600CDAD RID: 52653 RVA: 0x0006E30F File Offset: 0x0006C50F
			public unsafe static Func<KeyValuePair<string, SchedulerNode>, ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, SchedulerNode>, ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseScheduler.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400841A RID: 33818
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400841B RID: 33819
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x0400841C RID: 33820
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x0400841D RID: 33821
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x0400841E RID: 33822
			private static readonly IntPtr NativeFieldInfoPtr___9__30_3;

			// Token: 0x0400841F RID: 33823
			private static readonly IntPtr NativeFieldInfoPtr___9__30_4;

			// Token: 0x04008420 RID: 33824
			private static readonly IntPtr NativeFieldInfoPtr___9__30_5;

			// Token: 0x04008421 RID: 33825
			private static readonly IntPtr NativeFieldInfoPtr___9__30_6;

			// Token: 0x04008422 RID: 33826
			private static readonly IntPtr NativeFieldInfoPtr___9__30_7;

			// Token: 0x04008423 RID: 33827
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x04008424 RID: 33828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008425 RID: 33829
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_0_Internal_Dictionary_2_String_SchedulerNode_DataBaseSchedulerData_0;

			// Token: 0x04008426 RID: 33830
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_1_Internal_Dictionary_2_String_NewsNode_DataBaseSchedulerData_0;

			// Token: 0x04008427 RID: 33831
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_2_Internal_Dictionary_2_String_CGPictureProperty_DataBaseSchedulerData_0;

			// Token: 0x04008428 RID: 33832
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_3_Internal_Dictionary_2_String_SchedulerNode_DataBaseSchedulerData_0;

			// Token: 0x04008429 RID: 33833
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_4_Internal_Dictionary_2_String_NewsNode_DataBaseSchedulerData_0;

			// Token: 0x0400842A RID: 33834
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_5_Internal_Dictionary_2_String_CGPictureProperty_DataBaseSchedulerData_0;

			// Token: 0x0400842B RID: 33835
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_6_Internal_IEnumerable_1_SchedulerConnectionData_KeyValuePair_2_String_Il2CppReferenceArray_1_SchedulerConnectionData_0;

			// Token: 0x0400842C RID: 33836
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_7_Internal_IEnumerable_1_SchedulerNewsData_KeyValuePair_2_String_Il2CppReferenceArray_1_SchedulerNewsData_0;

			// Token: 0x0400842D RID: 33837
			private static readonly IntPtr NativeMethodInfoPtr__GetAllLabels_b__42_0_Internal_ValueTuple_4_NodeType_SchedulerType_String_String_KeyValuePair_2_String_SchedulerNode_0;
		}
	}
}
