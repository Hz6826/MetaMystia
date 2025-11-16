using System;
using System.Runtime.InteropServices;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene;

namespace DayScene
{
	// Token: 0x020000B1 RID: 177
	public class DaySceneDirector : MonoSingleton<DaySceneDirector>
	{
		// Token: 0x06001308 RID: 4872 RVA: 0x000DE604 File Offset: 0x000DC804
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneDirector()
		{
			Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene", "DaySceneDirector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr);
			DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_EASY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "OPTION_SELECTDIFFICULTY_EASY");
			DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_NORMAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "OPTION_SELECTDIFFICULTY_NORMAL");
			DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_HARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "OPTION_SELECTDIFFICULTY_HARD");
			DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_LUNATIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "OPTION_SELECTDIFFICULTY_LUNATIC");
			DaySceneDirector.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666585);
			DaySceneDirector.NativeMethodInfoPtr_StartManualWorkSceneSession_Public_Void_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IndexCookerPair_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666586);
			DaySceneDirector.NativeMethodInfoPtr_StartKyoukoTutorial_Public_Void_Int32_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666587);
			DaySceneDirector.NativeMethodInfoPtr_StartChallengeSession_Public_Void_ChallengeType_Boolean_Difficulty_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666588);
			DaySceneDirector.NativeMethodInfoPtr_StartWorkSceneChallengeSession_Private_Void_ChallengeType_Boolean_Difficulty_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666589);
			DaySceneDirector.NativeMethodInfoPtr_StartMusicGameChallengeSession_Private_Static_Void_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666590);
			DaySceneDirector.NativeMethodInfoPtr_StartMusicGameChallengeSessionAsyncInternal_Private_Static_UniTaskVoid_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666591);
			DaySceneDirector.NativeMethodInfoPtr_MoveToMap_Public_Void_String_String_Boolean_Boolean_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666592);
			DaySceneDirector.NativeMethodInfoPtr_GiveResource_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666593);
			DaySceneDirector.NativeMethodInfoPtr_SetSelectedMap_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666594);
			DaySceneDirector.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666595);
			DaySceneDirector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666596);
			DaySceneDirector.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, 100666597);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000DE788 File Offset: 0x000DC988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52717, XrefRangeEnd = 52720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDirector.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000DE7C4 File Offset: 0x000DC9C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52746, RefRangeEnd = 52747, XrefRangeStart = 52720, XrefRangeEnd = 52746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartManualWorkSceneSession(int izakayaIndex, Il2CppStructArray<int> dailyRecipes, Il2CppStructArray<int> dailyBeverages, Il2CppStructArray<DaySceneDirector.IndexCookerPair> cookerConfigurations, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dailyRecipes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dailyBeverages);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookerConfigurations);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_StartManualWorkSceneSession_Public_Void_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IndexCookerPair_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000DE84C File Offset: 0x000DCA4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52779, RefRangeEnd = 52781, XrefRangeStart = 52747, XrefRangeEnd = 52779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartKyoukoTutorial(int mapIndex = 0, Action onFinishCallback = null, Action onBackToDayCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mapIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBackToDayCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_StartKyoukoTutorial_Public_Void_Int32_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000DE8B0 File Offset: 0x000DCAB0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 52786, RefRangeEnd = 52802, XrefRangeStart = 52781, XrefRangeEnd = 52786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartChallengeSession(NightSceneDirector.ChallengeType challengeType, bool doNotFadeOut, NightSceneDirector.Difficulty difficulty = NightSceneDirector.Difficulty.None, Nullable<int> overrideChallengeIzakayaId = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref challengeType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotFadeOut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref difficulty;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideChallengeIzakayaId));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_StartChallengeSession_Public_Void_ChallengeType_Boolean_Difficulty_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000DE924 File Offset: 0x000DCB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52830, RefRangeEnd = 52831, XrefRangeStart = 52802, XrefRangeEnd = 52830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartWorkSceneChallengeSession(NightSceneDirector.ChallengeType challengeType, bool doNotFadeOut, NightSceneDirector.Difficulty difficulty = NightSceneDirector.Difficulty.None, Nullable<int> overrideChallengeIzakayaId = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref challengeType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotFadeOut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref difficulty;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideChallengeIzakayaId));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_StartWorkSceneChallengeSession_Private_Void_ChallengeType_Boolean_Difficulty_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000DE998 File Offset: 0x000DCB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52831, XrefRangeEnd = 52836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartMusicGameChallengeSession(NightSceneDirector.ChallengeType challengeType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref challengeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_StartMusicGameChallengeSession_Private_Static_Void_ChallengeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000DE9CC File Offset: 0x000DCBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52836, XrefRangeEnd = 52840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid StartMusicGameChallengeSessionAsyncInternal(NightSceneDirector.ChallengeType challengeType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref challengeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_StartMusicGameChallengeSessionAsyncInternal_Private_Static_UniTaskVoid_ChallengeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000DEA0C File Offset: 0x000DCC0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52848, RefRangeEnd = 52850, XrefRangeStart = 52840, XrefRangeEnd = 52848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToMap(string targetMapLabel, string targetMarkerName, bool shouldCostAction, bool shouldFadeInFadeOut, bool triggerEnterMapEvent, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(targetMapLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetMarkerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldCostAction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFadeInFadeOut;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerEnterMapEvent;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_MoveToMap_Public_Void_String_String_Boolean_Boolean_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000DEAA0 File Offset: 0x000DCCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52881, RefRangeEnd = 52882, XrefRangeStart = 52850, XrefRangeEnd = 52881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveResource(int resourceCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resourceCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_GiveResource_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000DEAE0 File Offset: 0x000DCCE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52897, RefRangeEnd = 52898, XrefRangeStart = 52882, XrefRangeEnd = 52897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedMap(string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_SetSelectedMap_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x000DEB24 File Offset: 0x000DCD24
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDirector.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000DEB60 File Offset: 0x000DCD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52898, XrefRangeEnd = 52901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneDirector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000DEB9C File Offset: 0x000DCD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52901, XrefRangeEnd = 52924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0000C12F File Offset: 0x0000A32F
		public DaySceneDirector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x000DEBC4 File Offset: 0x000DCDC4
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x0000C138 File Offset: 0x0000A338
		public unsafe static string OPTION_SELECTDIFFICULTY_EASY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_EASY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_EASY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x000DEBE4 File Offset: 0x000DCDE4
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0000C14A File Offset: 0x0000A34A
		public unsafe static string OPTION_SELECTDIFFICULTY_NORMAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_NORMAL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_NORMAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x000DEC04 File Offset: 0x000DCE04
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0000C15C File Offset: 0x0000A35C
		public unsafe static string OPTION_SELECTDIFFICULTY_HARD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_HARD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_HARD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x000DEC24 File Offset: 0x000DCE24
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x0000C16E File Offset: 0x0000A36E
		public unsafe static string OPTION_SELECTDIFFICULTY_LUNATIC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_LUNATIC, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_LUNATIC, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_EASY;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_NORMAL;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_HARD;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeFieldInfoPtr_OPTION_SELECTDIFFICULTY_LUNATIC;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_StartManualWorkSceneSession_Public_Void_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_IndexCookerPair_Action_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_StartKyoukoTutorial_Public_Void_Int32_Action_Action_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_StartChallengeSession_Public_Void_ChallengeType_Boolean_Difficulty_Nullable_1_Int32_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_StartWorkSceneChallengeSession_Private_Void_ChallengeType_Boolean_Difficulty_Nullable_1_Int32_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_StartMusicGameChallengeSession_Private_Static_Void_ChallengeType_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_StartMusicGameChallengeSessionAsyncInternal_Private_Static_UniTaskVoid_ChallengeType_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_MoveToMap_Public_Void_String_String_Boolean_Boolean_Boolean_Action_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_GiveResource_Public_Void_Int32_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedMap_Public_Void_String_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x020005C4 RID: 1476
		[Serializable]
		[StructLayout(2)]
		public struct IndexCookerPair
		{
			// Token: 0x06008CDD RID: 36061 RVA: 0x0026AAE4 File Offset: 0x00268CE4
			// Note: this type is marked as 'beforefieldinit'.
			static IndexCookerPair()
			{
				Il2CppClassPointerStore<DaySceneDirector.IndexCookerPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "IndexCookerPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector.IndexCookerPair>.NativeClassPtr);
				DaySceneDirector.IndexCookerPair.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.IndexCookerPair>.NativeClassPtr, "index");
				DaySceneDirector.IndexCookerPair.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.IndexCookerPair>.NativeClassPtr, "id");
			}

			// Token: 0x06008CDE RID: 36062 RVA: 0x0004BBA8 File Offset: 0x00049DA8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneDirector.IndexCookerPair>.NativeClassPtr, ref this));
			}

			// Token: 0x04005C1C RID: 23580
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04005C1D RID: 23581
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04005C1E RID: 23582
			[FieldOffset(0)]
			public int index;

			// Token: 0x04005C1F RID: 23583
			[FieldOffset(4)]
			public int id;
		}

		// Token: 0x020005C5 RID: 1477
		[ObfuscatedName("DayScene.DaySceneDirector+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06008CDF RID: 36063 RVA: 0x0026AB38 File Offset: 0x00268D38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr);
				DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_izakayaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, "izakayaIndex");
				DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_dailyRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, "dailyRecipes");
				DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_dailyBeverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, "dailyBeverages");
				DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_cookerConfigurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, "cookerConfigurations");
				DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, "onFinish");
				DaySceneDirector.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, 100666598);
				DaySceneDirector.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, 100666599);
				DaySceneDirector.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr, 100666600);
			}

			// Token: 0x06008CE0 RID: 36064 RVA: 0x0026AC04 File Offset: 0x00268E04
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CE1 RID: 36065 RVA: 0x0026AC40 File Offset: 0x00268E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52554, XrefRangeEnd = 52572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CE2 RID: 36066 RVA: 0x0026AC74 File Offset: 0x00268E74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52572, XrefRangeEnd = 52627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CE3 RID: 36067 RVA: 0x0004BBBA File Offset: 0x00049DBA
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F1E RID: 12062
			// (get) Token: 0x06008CE4 RID: 36068 RVA: 0x0026ACA8 File Offset: 0x00268EA8
			// (set) Token: 0x06008CE5 RID: 36069 RVA: 0x0004BBC3 File Offset: 0x00049DC3
			public unsafe int izakayaIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_izakayaIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_izakayaIndex)) = value;
				}
			}

			// Token: 0x17002F1F RID: 12063
			// (get) Token: 0x06008CE6 RID: 36070 RVA: 0x0026ACD0 File Offset: 0x00268ED0
			// (set) Token: 0x06008CE7 RID: 36071 RVA: 0x0004BBDE File Offset: 0x00049DDE
			public unsafe Il2CppStructArray<int> dailyRecipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_dailyRecipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_dailyRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F20 RID: 12064
			// (get) Token: 0x06008CE8 RID: 36072 RVA: 0x0026AD00 File Offset: 0x00268F00
			// (set) Token: 0x06008CE9 RID: 36073 RVA: 0x0004BBFD File Offset: 0x00049DFD
			public unsafe Il2CppStructArray<int> dailyBeverages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_dailyBeverages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_dailyBeverages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F21 RID: 12065
			// (get) Token: 0x06008CEA RID: 36074 RVA: 0x0026AD30 File Offset: 0x00268F30
			// (set) Token: 0x06008CEB RID: 36075 RVA: 0x0004BC1C File Offset: 0x00049E1C
			public unsafe Il2CppStructArray<DaySceneDirector.IndexCookerPair> cookerConfigurations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_cookerConfigurations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DaySceneDirector.IndexCookerPair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_cookerConfigurations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F22 RID: 12066
			// (get) Token: 0x06008CEC RID: 36076 RVA: 0x0026AD60 File Offset: 0x00268F60
			// (set) Token: 0x06008CED RID: 36077 RVA: 0x0004BC3B File Offset: 0x00049E3B
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass5_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C20 RID: 23584
			private static readonly IntPtr NativeFieldInfoPtr_izakayaIndex;

			// Token: 0x04005C21 RID: 23585
			private static readonly IntPtr NativeFieldInfoPtr_dailyRecipes;

			// Token: 0x04005C22 RID: 23586
			private static readonly IntPtr NativeFieldInfoPtr_dailyBeverages;

			// Token: 0x04005C23 RID: 23587
			private static readonly IntPtr NativeFieldInfoPtr_cookerConfigurations;

			// Token: 0x04005C24 RID: 23588
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04005C25 RID: 23589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C26 RID: 23590
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04005C27 RID: 23591
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}

		// Token: 0x020005C6 RID: 1478
		[ObfuscatedName("DayScene.DaySceneDirector+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06008CEE RID: 36078 RVA: 0x0026AD90 File Offset: 0x00268F90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr);
				DaySceneDirector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, "<>9");
				DaySceneDirector.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, "<>9__5_2");
				DaySceneDirector.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, "<>9__5_3");
				DaySceneDirector.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, "<>9__5_4");
				DaySceneDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, 100666602);
				DaySceneDirector.__c.NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, 100666603);
				DaySceneDirector.__c.NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, 100666604);
				DaySceneDirector.__c.NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_4_Internal_Void_IndexCookerPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr, 100666605);
			}

			// Token: 0x06008CEF RID: 36079 RVA: 0x0026AE5C File Offset: 0x0026905C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDirector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CF0 RID: 36080 RVA: 0x0026AE98 File Offset: 0x00269098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52627, XrefRangeEnd = 52632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartManualWorkSceneSession_b__5_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c.NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CF1 RID: 36081 RVA: 0x0026AED8 File Offset: 0x002690D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52632, XrefRangeEnd = 52637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartManualWorkSceneSession_b__5_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c.NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CF2 RID: 36082 RVA: 0x0026AF18 File Offset: 0x00269118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52637, XrefRangeEnd = 52641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartManualWorkSceneSession_b__5_4(DaySceneDirector.IndexCookerPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c.NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_4_Internal_Void_IndexCookerPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CF3 RID: 36083 RVA: 0x0004BC5A File Offset: 0x00049E5A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F23 RID: 12067
			// (get) Token: 0x06008CF4 RID: 36084 RVA: 0x0026AF58 File Offset: 0x00269158
			// (set) Token: 0x06008CF5 RID: 36085 RVA: 0x0004BC63 File Offset: 0x00049E63
			public unsafe static DaySceneDirector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDirector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F24 RID: 12068
			// (get) Token: 0x06008CF6 RID: 36086 RVA: 0x0026AF80 File Offset: 0x00269180
			// (set) Token: 0x06008CF7 RID: 36087 RVA: 0x0004BC75 File Offset: 0x00049E75
			public unsafe static Action<int> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F25 RID: 12069
			// (get) Token: 0x06008CF8 RID: 36088 RVA: 0x0026AFA8 File Offset: 0x002691A8
			// (set) Token: 0x06008CF9 RID: 36089 RVA: 0x0004BC87 File Offset: 0x00049E87
			public unsafe static Action<int> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F26 RID: 12070
			// (get) Token: 0x06008CFA RID: 36090 RVA: 0x0026AFD0 File Offset: 0x002691D0
			// (set) Token: 0x06008CFB RID: 36091 RVA: 0x0004BC99 File Offset: 0x00049E99
			public unsafe static Action<DaySceneDirector.IndexCookerPair> __9__5_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDirector.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DaySceneDirector.IndexCookerPair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDirector.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C28 RID: 23592
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005C29 RID: 23593
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x04005C2A RID: 23594
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x04005C2B RID: 23595
			private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

			// Token: 0x04005C2C RID: 23596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C2D RID: 23597
			private static readonly IntPtr NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_2_Internal_Void_Int32_0;

			// Token: 0x04005C2E RID: 23598
			private static readonly IntPtr NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_3_Internal_Void_Int32_0;

			// Token: 0x04005C2F RID: 23599
			private static readonly IntPtr NativeMethodInfoPtr__StartManualWorkSceneSession_b__5_4_Internal_Void_IndexCookerPair_0;
		}

		// Token: 0x020005C7 RID: 1479
		[ObfuscatedName("DayScene.DaySceneDirector+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06008CFC RID: 36092 RVA: 0x0026AFF8 File Offset: 0x002691F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass6_0>.NativeClassPtr);
				DaySceneDirector.__c__DisplayClass6_0.NativeFieldInfoPtr_mapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass6_0>.NativeClassPtr, "mapIndex");
				DaySceneDirector.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass6_0>.NativeClassPtr, 100666606);
				DaySceneDirector.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass6_0>.NativeClassPtr, 100666607);
			}

			// Token: 0x06008CFD RID: 36093 RVA: 0x0026B060 File Offset: 0x00269260
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CFE RID: 36094 RVA: 0x0026B09C File Offset: 0x0026929C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52641, XrefRangeEnd = 52659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CFF RID: 36095 RVA: 0x0004BCAB File Offset: 0x00049EAB
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F27 RID: 12071
			// (get) Token: 0x06008D00 RID: 36096 RVA: 0x0026B0D0 File Offset: 0x002692D0
			// (set) Token: 0x06008D01 RID: 36097 RVA: 0x0004BCB4 File Offset: 0x00049EB4
			public unsafe int mapIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass6_0.NativeFieldInfoPtr_mapIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass6_0.NativeFieldInfoPtr_mapIndex)) = value;
				}
			}

			// Token: 0x04005C30 RID: 23600
			private static readonly IntPtr NativeFieldInfoPtr_mapIndex;

			// Token: 0x04005C31 RID: 23601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C32 RID: 23602
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020005C8 RID: 1480
		[ObfuscatedName("DayScene.DaySceneDirector+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06008D02 RID: 36098 RVA: 0x0026B0F8 File Offset: 0x002692F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass8_0>.NativeClassPtr);
				DaySceneDirector.__c__DisplayClass8_0.NativeFieldInfoPtr_challengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass8_0>.NativeClassPtr, "challengeType");
				DaySceneDirector.__c__DisplayClass8_0.NativeFieldInfoPtr_overrideChallengeIzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass8_0>.NativeClassPtr, "overrideChallengeIzakayaId");
				DaySceneDirector.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass8_0>.NativeClassPtr, 100666608);
				DaySceneDirector.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass8_0>.NativeClassPtr, 100666609);
			}

			// Token: 0x06008D03 RID: 36099 RVA: 0x0026B174 File Offset: 0x00269374
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D04 RID: 36100 RVA: 0x0026B1B0 File Offset: 0x002693B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52659, XrefRangeEnd = 52693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D05 RID: 36101 RVA: 0x0004BCCF File Offset: 0x00049ECF
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F28 RID: 12072
			// (get) Token: 0x06008D06 RID: 36102 RVA: 0x0026B1E4 File Offset: 0x002693E4
			// (set) Token: 0x06008D07 RID: 36103 RVA: 0x0004BCD8 File Offset: 0x00049ED8
			public unsafe NightSceneDirector.ChallengeType challengeType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass8_0.NativeFieldInfoPtr_challengeType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass8_0.NativeFieldInfoPtr_challengeType)) = value;
				}
			}

			// Token: 0x17002F29 RID: 12073
			// (get) Token: 0x06008D08 RID: 36104 RVA: 0x0026B20C File Offset: 0x0026940C
			// (set) Token: 0x06008D09 RID: 36105 RVA: 0x0004BCF3 File Offset: 0x00049EF3
			public Nullable<int> overrideChallengeIzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass8_0.NativeFieldInfoPtr_overrideChallengeIzakayaId);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass8_0.NativeFieldInfoPtr_overrideChallengeIzakayaId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005C33 RID: 23603
			private static readonly IntPtr NativeFieldInfoPtr_challengeType;

			// Token: 0x04005C34 RID: 23604
			private static readonly IntPtr NativeFieldInfoPtr_overrideChallengeIzakayaId;

			// Token: 0x04005C35 RID: 23605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C36 RID: 23606
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020005C9 RID: 1481
		[ObfuscatedName("DayScene.DaySceneDirector+<StartMusicGameChallengeSessionAsyncInternal>d__10")]
		public sealed class _StartMusicGameChallengeSessionAsyncInternal_d__10 : ValueType
		{
			// Token: 0x06008D0A RID: 36106 RVA: 0x0026B23C File Offset: 0x0026943C
			// Note: this type is marked as 'beforefieldinit'.
			static _StartMusicGameChallengeSessionAsyncInternal_d__10()
			{
				Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "<StartMusicGameChallengeSessionAsyncInternal>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr);
				DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr, "<>1__state");
				DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr, "<>t__builder");
				DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr_challengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr, "challengeType");
				DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr, "<>u__1");
				DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr, 100666610);
				DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr, 100666611);
			}

			// Token: 0x06008D0B RID: 36107 RVA: 0x0026B2E0 File Offset: 0x002694E0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 52709, RefRangeEnd = 52711, XrefRangeStart = 52693, XrefRangeEnd = 52709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D0C RID: 36108 RVA: 0x0026B318 File Offset: 0x00269518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D0D RID: 36109 RVA: 0x0004BD21 File Offset: 0x00049F21
			public _StartMusicGameChallengeSessionAsyncInternal_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008D0E RID: 36110 RVA: 0x0004BD2A File Offset: 0x00049F2A
			public _StartMusicGameChallengeSessionAsyncInternal_d__10() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10>.NativeClassPtr))
			{
			}

			// Token: 0x17002F2A RID: 12074
			// (get) Token: 0x06008D0F RID: 36111 RVA: 0x0026B360 File Offset: 0x00269560
			// (set) Token: 0x06008D10 RID: 36112 RVA: 0x0004BD3C File Offset: 0x00049F3C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F2B RID: 12075
			// (get) Token: 0x06008D11 RID: 36113 RVA: 0x0026B388 File Offset: 0x00269588
			// (set) Token: 0x06008D12 RID: 36114 RVA: 0x0004BD57 File Offset: 0x00049F57
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F2C RID: 12076
			// (get) Token: 0x06008D13 RID: 36115 RVA: 0x0026B3B8 File Offset: 0x002695B8
			// (set) Token: 0x06008D14 RID: 36116 RVA: 0x0004BD85 File Offset: 0x00049F85
			public unsafe NightSceneDirector.ChallengeType challengeType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr_challengeType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr_challengeType)) = value;
				}
			}

			// Token: 0x17002F2D RID: 12077
			// (get) Token: 0x06008D15 RID: 36117 RVA: 0x0026B3E0 File Offset: 0x002695E0
			// (set) Token: 0x06008D16 RID: 36118 RVA: 0x0004BDA0 File Offset: 0x00049FA0
			public UniTask<DLC3_MusicGameStartPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC3_MusicGameStartPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC3_MusicGameStartPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector._StartMusicGameChallengeSessionAsyncInternal_d__10.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC3_MusicGameStartPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005C37 RID: 23607
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005C38 RID: 23608
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005C39 RID: 23609
			private static readonly IntPtr NativeFieldInfoPtr_challengeType;

			// Token: 0x04005C3A RID: 23610
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005C3B RID: 23611
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005C3C RID: 23612
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005CA RID: 1482
		[ObfuscatedName("DayScene.DaySceneDirector+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06008D17 RID: 36119 RVA: 0x0026B410 File Offset: 0x00269610
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDirector>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass13_0>.NativeClassPtr);
				DaySceneDirector.__c__DisplayClass13_0.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass13_0>.NativeClassPtr, "mapLabel");
				DaySceneDirector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass13_0>.NativeClassPtr, 100666612);
				DaySceneDirector.__c__DisplayClass13_0.NativeMethodInfoPtr__SetSelectedMap_b__0_Internal_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass13_0>.NativeClassPtr, 100666613);
			}

			// Token: 0x06008D18 RID: 36120 RVA: 0x0026B478 File Offset: 0x00269678
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDirector.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D19 RID: 36121 RVA: 0x0026B4B4 File Offset: 0x002696B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52711, XrefRangeEnd = 52717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetSelectedMap_b__0(IGuideMapSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDirector.__c__DisplayClass13_0.NativeMethodInfoPtr__SetSelectedMap_b__0_Internal_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008D1A RID: 36122 RVA: 0x0004BDCE File Offset: 0x00049FCE
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F2E RID: 12078
			// (get) Token: 0x06008D1B RID: 36123 RVA: 0x0026B504 File Offset: 0x00269704
			// (set) Token: 0x06008D1C RID: 36124 RVA: 0x0004BDD7 File Offset: 0x00049FD7
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass13_0.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDirector.__c__DisplayClass13_0.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04005C3D RID: 23613
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x04005C3E RID: 23614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C3F RID: 23615
			private static readonly IntPtr NativeMethodInfoPtr__SetSelectedMap_b__0_Internal_Boolean_IGuideMapSpot_0;
		}
	}
}
