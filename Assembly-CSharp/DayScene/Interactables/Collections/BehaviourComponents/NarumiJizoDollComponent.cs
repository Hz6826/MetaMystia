using System;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000190 RID: 400
	public class NarumiJizoDollComponent : EntityBehaviourComponent
	{
		// Token: 0x06002B18 RID: 11032 RVA: 0x0012DA80 File Offset: 0x0012BC80
		// Note: this type is marked as 'beforefieldinit'.
		static NarumiJizoDollComponent()
		{
			Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "NarumiJizoDollComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr);
			NarumiJizoDollComponent.NativeFieldInfoPtr_EndDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "EndDialog");
			NarumiJizoDollComponent.NativeFieldInfoPtr_runOutOfLotteryDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "runOutOfLotteryDialogs");
			NarumiJizoDollComponent.NativeFieldInfoPtr_openDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "openDialog");
			NarumiJizoDollComponent.NativeFieldInfoPtr_rewardDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "rewardDialog");
			NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "ingredientNum");
			NarumiJizoDollComponent.NativeFieldInfoPtr_bevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "bevNum");
			NarumiJizoDollComponent.NativeFieldInfoPtr_reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "reward");
			NarumiJizoDollComponent.NativeFieldInfoPtr_interactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "interactCount");
			NarumiJizoDollComponent.NativeFieldInfoPtr_bevPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "bevPercentage");
			NarumiJizoDollComponent.NativeFieldInfoPtr_bevReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "bevReward");
			NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "ingredientPercentage");
			NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "ingredientReward");
			NarumiJizoDollComponent.NativeFieldInfoPtr_moduleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "moduleID");
			NarumiJizoDollComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670781);
			NarumiJizoDollComponent.NativeMethodInfoPtr_GiveItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670782);
			NarumiJizoDollComponent.NativeMethodInfoPtr_CalculateItemsPercentage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670783);
			NarumiJizoDollComponent.NativeMethodInfoPtr_GetReward_Private_NarumiJizoDollRewardPair_Il2CppStructArray_1_Int32_Il2CppStructArray_1_NarumiJizoDollRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670784);
			NarumiJizoDollComponent.NativeMethodInfoPtr_SelectReward_Private_Int32_NarumiJizoDollRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670785);
			NarumiJizoDollComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670786);
			NarumiJizoDollComponent.NativeMethodInfoPtr_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670787);
			NarumiJizoDollComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670788);
			NarumiJizoDollComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, 100670789);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0012DC68 File Offset: 0x0012BE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95953, XrefRangeEnd = 95959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NarumiJizoDollComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x0012DCA4 File Offset: 0x0012BEA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95985, RefRangeEnd = 95986, XrefRangeStart = 95959, XrefRangeEnd = 95985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.NativeMethodInfoPtr_GiveItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x0012DCD8 File Offset: 0x0012BED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96068, RefRangeEnd = 96069, XrefRangeStart = 95986, XrefRangeEnd = 96068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateItemsPercentage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.NativeMethodInfoPtr_CalculateItemsPercentage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0012DD0C File Offset: 0x0012BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96069, XrefRangeEnd = 96072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NarumiJizoDollRewardPair GetReward(Il2CppStructArray<int> targetPercentage, Il2CppStructArray<NarumiJizoDollRewardPair> targetRewardArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPercentage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetRewardArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.NativeMethodInfoPtr_GetReward_Private_NarumiJizoDollRewardPair_Il2CppStructArray_1_Int32_Il2CppStructArray_1_NarumiJizoDollRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0012DD6C File Offset: 0x0012BF6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96218, RefRangeEnd = 96220, XrefRangeStart = 96072, XrefRangeEnd = 96218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SelectReward(NarumiJizoDollRewardPair rewardPair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rewardPair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.NativeMethodInfoPtr_SelectReward_Private_Int32_NarumiJizoDollRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x0012DDB8 File Offset: 0x0012BFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96220, XrefRangeEnd = 96235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NarumiJizoDollComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0012DDF4 File Offset: 0x0012BFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96235, XrefRangeEnd = 96242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayDialog<T>(Il2CppArrayBase<T> dialogs, Action action) where T : DialogPackage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.MethodInfoStoreGeneric_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x0012DE48 File Offset: 0x0012C048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96242, XrefRangeEnd = 96252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NarumiJizoDollComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0012DE84 File Offset: 0x0012C084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96252, XrefRangeEnd = 96259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NarumiJizoDollComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0001911F File Offset: 0x0001731F
		public NarumiJizoDollComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x0012DEC0 File Offset: 0x0012C0C0
		// (set) Token: 0x06002B24 RID: 11044 RVA: 0x00019128 File Offset: 0x00017328
		public unsafe Il2CppReferenceArray<DialogPackage> EndDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_EndDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_EndDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x0012DEF0 File Offset: 0x0012C0F0
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x00019147 File Offset: 0x00017347
		public unsafe Il2CppReferenceArray<DialogPackage> runOutOfLotteryDialogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_runOutOfLotteryDialogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_runOutOfLotteryDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x0012DF20 File Offset: 0x0012C120
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x00019166 File Offset: 0x00017366
		public unsafe Il2CppReferenceArray<DialogPackage> openDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_openDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_openDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x0012DF50 File Offset: 0x0012C150
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00019185 File Offset: 0x00017385
		public unsafe Il2CppReferenceArray<DialogPackage> rewardDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_rewardDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_rewardDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x0012DF80 File Offset: 0x0012C180
		// (set) Token: 0x06002B2C RID: 11052 RVA: 0x000191A4 File Offset: 0x000173A4
		public unsafe int ingredientNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientNum)) = value;
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x0012DFA8 File Offset: 0x0012C1A8
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x000191BF File Offset: 0x000173BF
		public unsafe int bevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_bevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_bevNum)) = value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x0012DFD0 File Offset: 0x0012C1D0
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x000191DA File Offset: 0x000173DA
		public unsafe Il2CppStructArray<NarumiJizoDollRewardPair> reward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_reward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NarumiJizoDollRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_reward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x0012E000 File Offset: 0x0012C200
		// (set) Token: 0x06002B32 RID: 11058 RVA: 0x000191F9 File Offset: 0x000173F9
		public unsafe int interactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_interactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_interactCount)) = value;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x0012E028 File Offset: 0x0012C228
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x00019214 File Offset: 0x00017414
		public unsafe Il2CppStructArray<int> bevPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_bevPercentage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_bevPercentage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x0012E058 File Offset: 0x0012C258
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x00019233 File Offset: 0x00017433
		public unsafe Il2CppStructArray<NarumiJizoDollRewardPair> bevReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_bevReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NarumiJizoDollRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_bevReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x0012E088 File Offset: 0x0012C288
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x00019252 File Offset: 0x00017452
		public unsafe Il2CppStructArray<int> ingredientPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientPercentage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientPercentage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x0012E0B8 File Offset: 0x0012C2B8
		// (set) Token: 0x06002B3A RID: 11066 RVA: 0x00019271 File Offset: 0x00017471
		public unsafe Il2CppStructArray<NarumiJizoDollRewardPair> ingredientReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NarumiJizoDollRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_ingredientReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x0012E0E8 File Offset: 0x0012C2E8
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x00019290 File Offset: 0x00017490
		public unsafe string moduleID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_moduleID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NarumiJizoDollComponent.NativeFieldInfoPtr_moduleID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001C86 RID: 7302
		private static readonly IntPtr NativeFieldInfoPtr_EndDialog;

		// Token: 0x04001C87 RID: 7303
		private static readonly IntPtr NativeFieldInfoPtr_runOutOfLotteryDialogs;

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_openDialog;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeFieldInfoPtr_rewardDialog;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeFieldInfoPtr_ingredientNum;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeFieldInfoPtr_bevNum;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr_reward;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr_interactCount;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeFieldInfoPtr_bevPercentage;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeFieldInfoPtr_bevReward;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPercentage;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeFieldInfoPtr_ingredientReward;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeFieldInfoPtr_moduleID;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_GiveItem_Private_Void_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_CalculateItemsPercentage_Private_Void_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_GetReward_Private_NarumiJizoDollRewardPair_Il2CppStructArray_1_Int32_Il2CppStructArray_1_NarumiJizoDollRewardPair_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_SelectReward_Private_Int32_NarumiJizoDollRewardPair_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C2 RID: 1986
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NarumiJizoDollComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A597 RID: 42391 RVA: 0x002B38B4 File Offset: 0x002B1AB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr);
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__15_0");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__15_1");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__15_2");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__15_3");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_0");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_1");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_2");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_3");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_4");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_5");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_6");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_7");
				NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, "<>9__17_8");
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670791);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_0_Internal_Boolean_NarumiJizoDollRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670792);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_1_Internal_Single_NarumiJizoDollRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670793);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_2_Internal_Boolean_NarumiJizoDollRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670794);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_3_Internal_Single_NarumiJizoDollRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670795);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_0_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670796);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_1_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670797);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_2_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670798);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_3_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670799);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_4_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670800);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_5_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670801);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670802);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_7_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670803);
				NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_8_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr, 100670804);
			}

			// Token: 0x0600A598 RID: 42392 RVA: 0x002B3B10 File Offset: 0x002B1D10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NarumiJizoDollComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A599 RID: 42393 RVA: 0x002B3B4C File Offset: 0x002B1D4C
			[CallerCount(0)]
			public unsafe bool _CalculateItemsPercentage_b__15_0(NarumiJizoDollRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_0_Internal_Boolean_NarumiJizoDollRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A59A RID: 42394 RVA: 0x002B3B98 File Offset: 0x002B1D98
			[CallerCount(0)]
			public unsafe float _CalculateItemsPercentage_b__15_1(NarumiJizoDollRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_1_Internal_Single_NarumiJizoDollRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A59B RID: 42395 RVA: 0x002B3BE4 File Offset: 0x002B1DE4
			[CallerCount(0)]
			public unsafe bool _CalculateItemsPercentage_b__15_2(NarumiJizoDollRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_2_Internal_Boolean_NarumiJizoDollRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A59C RID: 42396 RVA: 0x002B3C30 File Offset: 0x002B1E30
			[CallerCount(0)]
			public unsafe float _CalculateItemsPercentage_b__15_3(NarumiJizoDollRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__CalculateItemsPercentage_b__15_3_Internal_Single_NarumiJizoDollRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A59D RID: 42397 RVA: 0x002B3C7C File Offset: 0x002B1E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95949, XrefRangeEnd = 95950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__17_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_0_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600A59E RID: 42398 RVA: 0x002B3CC8 File Offset: 0x002B1EC8
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__17_1(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_1_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A59F RID: 42399 RVA: 0x002B3D18 File Offset: 0x002B1F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__17_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_2_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600A5A0 RID: 42400 RVA: 0x002B3D64 File Offset: 0x002B1F64
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__17_3(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_3_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5A1 RID: 42401 RVA: 0x002B3DB4 File Offset: 0x002B1FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__17_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_4_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600A5A2 RID: 42402 RVA: 0x002B3E00 File Offset: 0x002B2000
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__17_5(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_5_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5A3 RID: 42403 RVA: 0x002B3E50 File Offset: 0x002B2050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95950, XrefRangeEnd = 95951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__17_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5A4 RID: 42404 RVA: 0x002B3E9C File Offset: 0x002B209C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95951, XrefRangeEnd = 95952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__17_7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_7_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5A5 RID: 42405 RVA: 0x002B3EE8 File Offset: 0x002B20E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95952, XrefRangeEnd = 95953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__17_8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NarumiJizoDollComponent.__c.NativeMethodInfoPtr__SelectReward_b__17_8_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5A6 RID: 42406 RVA: 0x000598C8 File Offset: 0x00057AC8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003688 RID: 13960
			// (get) Token: 0x0600A5A7 RID: 42407 RVA: 0x002B3F34 File Offset: 0x002B2134
			// (set) Token: 0x0600A5A8 RID: 42408 RVA: 0x000598D1 File Offset: 0x00057AD1
			public unsafe static NarumiJizoDollComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NarumiJizoDollComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003689 RID: 13961
			// (get) Token: 0x0600A5A9 RID: 42409 RVA: 0x002B3F5C File Offset: 0x002B215C
			// (set) Token: 0x0600A5AA RID: 42410 RVA: 0x000598E3 File Offset: 0x00057AE3
			public unsafe static Func<NarumiJizoDollRewardPair, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NarumiJizoDollRewardPair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368A RID: 13962
			// (get) Token: 0x0600A5AB RID: 42411 RVA: 0x002B3F84 File Offset: 0x002B2184
			// (set) Token: 0x0600A5AC RID: 42412 RVA: 0x000598F5 File Offset: 0x00057AF5
			public unsafe static Func<NarumiJizoDollRewardPair, float> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NarumiJizoDollRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368B RID: 13963
			// (get) Token: 0x0600A5AD RID: 42413 RVA: 0x002B3FAC File Offset: 0x002B21AC
			// (set) Token: 0x0600A5AE RID: 42414 RVA: 0x00059907 File Offset: 0x00057B07
			public unsafe static Func<NarumiJizoDollRewardPair, bool> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NarumiJizoDollRewardPair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368C RID: 13964
			// (get) Token: 0x0600A5AF RID: 42415 RVA: 0x002B3FD4 File Offset: 0x002B21D4
			// (set) Token: 0x0600A5B0 RID: 42416 RVA: 0x00059919 File Offset: 0x00057B19
			public unsafe static Func<NarumiJizoDollRewardPair, float> __9__15_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NarumiJizoDollRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__15_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368D RID: 13965
			// (get) Token: 0x0600A5B1 RID: 42417 RVA: 0x002B3FFC File Offset: 0x002B21FC
			// (set) Token: 0x0600A5B2 RID: 42418 RVA: 0x0005992B File Offset: 0x00057B2B
			public unsafe static Func<int, Ingredient> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368E RID: 13966
			// (get) Token: 0x0600A5B3 RID: 42419 RVA: 0x002B4024 File Offset: 0x002B2224
			// (set) Token: 0x0600A5B4 RID: 42420 RVA: 0x0005993D File Offset: 0x00057B3D
			public unsafe static Func<Ingredient, bool> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368F RID: 13967
			// (get) Token: 0x0600A5B5 RID: 42421 RVA: 0x002B404C File Offset: 0x002B224C
			// (set) Token: 0x0600A5B6 RID: 42422 RVA: 0x0005994F File Offset: 0x00057B4F
			public unsafe static Func<int, Ingredient> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003690 RID: 13968
			// (get) Token: 0x0600A5B7 RID: 42423 RVA: 0x002B4074 File Offset: 0x002B2274
			// (set) Token: 0x0600A5B8 RID: 42424 RVA: 0x00059961 File Offset: 0x00057B61
			public unsafe static Func<Ingredient, bool> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003691 RID: 13969
			// (get) Token: 0x0600A5B9 RID: 42425 RVA: 0x002B409C File Offset: 0x002B229C
			// (set) Token: 0x0600A5BA RID: 42426 RVA: 0x00059973 File Offset: 0x00057B73
			public unsafe static Func<int, Ingredient> __9__17_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003692 RID: 13970
			// (get) Token: 0x0600A5BB RID: 42427 RVA: 0x002B40C4 File Offset: 0x002B22C4
			// (set) Token: 0x0600A5BC RID: 42428 RVA: 0x00059985 File Offset: 0x00057B85
			public unsafe static Func<Ingredient, bool> __9__17_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003693 RID: 13971
			// (get) Token: 0x0600A5BD RID: 42429 RVA: 0x002B40EC File Offset: 0x002B22EC
			// (set) Token: 0x0600A5BE RID: 42430 RVA: 0x00059997 File Offset: 0x00057B97
			public unsafe static Func<int, bool> __9__17_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003694 RID: 13972
			// (get) Token: 0x0600A5BF RID: 42431 RVA: 0x002B4114 File Offset: 0x002B2314
			// (set) Token: 0x0600A5C0 RID: 42432 RVA: 0x000599A9 File Offset: 0x00057BA9
			public unsafe static Func<int, bool> __9__17_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003695 RID: 13973
			// (get) Token: 0x0600A5C1 RID: 42433 RVA: 0x002B413C File Offset: 0x002B233C
			// (set) Token: 0x0600A5C2 RID: 42434 RVA: 0x000599BB File Offset: 0x00057BBB
			public unsafe static Func<int, bool> __9__17_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NarumiJizoDollComponent.__c.NativeFieldInfoPtr___9__17_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006B0F RID: 27407
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006B10 RID: 27408
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04006B11 RID: 27409
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x04006B12 RID: 27410
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x04006B13 RID: 27411
			private static readonly IntPtr NativeFieldInfoPtr___9__15_3;

			// Token: 0x04006B14 RID: 27412
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04006B15 RID: 27413
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04006B16 RID: 27414
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x04006B17 RID: 27415
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x04006B18 RID: 27416
			private static readonly IntPtr NativeFieldInfoPtr___9__17_4;

			// Token: 0x04006B19 RID: 27417
			private static readonly IntPtr NativeFieldInfoPtr___9__17_5;

			// Token: 0x04006B1A RID: 27418
			private static readonly IntPtr NativeFieldInfoPtr___9__17_6;

			// Token: 0x04006B1B RID: 27419
			private static readonly IntPtr NativeFieldInfoPtr___9__17_7;

			// Token: 0x04006B1C RID: 27420
			private static readonly IntPtr NativeFieldInfoPtr___9__17_8;

			// Token: 0x04006B1D RID: 27421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006B1E RID: 27422
			private static readonly IntPtr NativeMethodInfoPtr__CalculateItemsPercentage_b__15_0_Internal_Boolean_NarumiJizoDollRewardPair_0;

			// Token: 0x04006B1F RID: 27423
			private static readonly IntPtr NativeMethodInfoPtr__CalculateItemsPercentage_b__15_1_Internal_Single_NarumiJizoDollRewardPair_0;

			// Token: 0x04006B20 RID: 27424
			private static readonly IntPtr NativeMethodInfoPtr__CalculateItemsPercentage_b__15_2_Internal_Boolean_NarumiJizoDollRewardPair_0;

			// Token: 0x04006B21 RID: 27425
			private static readonly IntPtr NativeMethodInfoPtr__CalculateItemsPercentage_b__15_3_Internal_Single_NarumiJizoDollRewardPair_0;

			// Token: 0x04006B22 RID: 27426
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_0_Internal_Ingredient_Int32_0;

			// Token: 0x04006B23 RID: 27427
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_1_Internal_Boolean_Ingredient_0;

			// Token: 0x04006B24 RID: 27428
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_2_Internal_Ingredient_Int32_0;

			// Token: 0x04006B25 RID: 27429
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_3_Internal_Boolean_Ingredient_0;

			// Token: 0x04006B26 RID: 27430
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_4_Internal_Ingredient_Int32_0;

			// Token: 0x04006B27 RID: 27431
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_5_Internal_Boolean_Ingredient_0;

			// Token: 0x04006B28 RID: 27432
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_6_Internal_Boolean_Int32_0;

			// Token: 0x04006B29 RID: 27433
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_7_Internal_Boolean_Int32_0;

			// Token: 0x04006B2A RID: 27434
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__17_8_Internal_Boolean_Int32_0;
		}

		// Token: 0x020007C3 RID: 1987
		private sealed class MethodInfoStoreGeneric_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0<T>
		{
			// Token: 0x04006B2B RID: 27435
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NarumiJizoDollComponent.NativeMethodInfoPtr_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0, Il2CppClassPointerStore<NarumiJizoDollComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
