using System;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000189 RID: 393
	public class MoriyaShrineBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002A9E RID: 10910 RVA: 0x0012C150 File Offset: 0x0012A350
		// Note: this type is marked as 'beforefieldinit'.
		static MoriyaShrineBehaviourComponent()
		{
			Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "MoriyaShrineBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr);
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_SILVER_COIN_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "SILVER_COIN_ID");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_GOLD_COIN_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "GOLD_COIN_ID");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_JK_CLOTHES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "JK_CLOTHES");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_WIND_BEVERAGE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "WIND_BEVERAGE_ID");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_CONDITION_FULFILLED_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "CONDITION_FULFILLED_COUNT");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_ACTION_CONSUMPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "ACTION_CONSUMPTION");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_COMPONENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "COMPONENT_ID");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_interactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "interactCount");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_beginDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "beginDialogs");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_runOutOfLotteryDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "runOutOfLotteryDialogs");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_noRewardDialogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "noRewardDialogs");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_conditionFulfilledTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "conditionFulfilledTimeline");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_Rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "Rewards");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_rewardActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "rewardActions");
			MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_itemsPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "itemsPercentage");
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670705);
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670706);
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_InitializeRewardActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670707);
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_Lottery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670708);
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670709);
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670710);
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670711);
			MoriyaShrineBehaviourComponent.NativeMethodInfoPtr__Lottery_b__18_1_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, 100670712);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0012C34C File Offset: 0x0012A54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95492, XrefRangeEnd = 95517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0012C388 File Offset: 0x0012A588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95517, XrefRangeEnd = 95539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x0012C3C4 File Offset: 0x0012A5C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95586, RefRangeEnd = 95587, XrefRangeStart = 95539, XrefRangeEnd = 95586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeRewardActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_InitializeRewardActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0012C3F8 File Offset: 0x0012A5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95587, XrefRangeEnd = 95634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lottery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_Lottery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0012C42C File Offset: 0x0012A62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95641, RefRangeEnd = 95642, XrefRangeStart = 95634, XrefRangeEnd = 95641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayDialog<T>(Il2CppArrayBase<T> dialogs, Action action) where T : DialogPackage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.MethodInfoStoreGeneric_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0012C480 File Offset: 0x0012A680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95642, XrefRangeEnd = 95651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x0012C4BC File Offset: 0x0012A6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95651, XrefRangeEnd = 95665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoriyaShrineBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x0012C4F8 File Offset: 0x0012A6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95665, XrefRangeEnd = 95681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Lottery_b__18_1(Action x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.NativeMethodInfoPtr__Lottery_b__18_1_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00018E0B File Offset: 0x0001700B
		public MoriyaShrineBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002AA8 RID: 10920 RVA: 0x0012C53C File Offset: 0x0012A73C
		// (set) Token: 0x06002AA9 RID: 10921 RVA: 0x00018E14 File Offset: 0x00017014
		public unsafe static int SILVER_COIN_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_SILVER_COIN_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_SILVER_COIN_ID, (void*)(&value));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002AAA RID: 10922 RVA: 0x0012C558 File Offset: 0x0012A758
		// (set) Token: 0x06002AAB RID: 10923 RVA: 0x00018E22 File Offset: 0x00017022
		public unsafe static int GOLD_COIN_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_GOLD_COIN_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_GOLD_COIN_ID, (void*)(&value));
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002AAC RID: 10924 RVA: 0x0012C574 File Offset: 0x0012A774
		// (set) Token: 0x06002AAD RID: 10925 RVA: 0x00018E30 File Offset: 0x00017030
		public unsafe static int JK_CLOTHES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_JK_CLOTHES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_JK_CLOTHES, (void*)(&value));
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x0012C590 File Offset: 0x0012A790
		// (set) Token: 0x06002AAF RID: 10927 RVA: 0x00018E3E File Offset: 0x0001703E
		public unsafe static int WIND_BEVERAGE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_WIND_BEVERAGE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_WIND_BEVERAGE_ID, (void*)(&value));
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x0012C5AC File Offset: 0x0012A7AC
		// (set) Token: 0x06002AB1 RID: 10929 RVA: 0x00018E4C File Offset: 0x0001704C
		public unsafe static int CONDITION_FULFILLED_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_CONDITION_FULFILLED_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_CONDITION_FULFILLED_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x0012C5C8 File Offset: 0x0012A7C8
		// (set) Token: 0x06002AB3 RID: 10931 RVA: 0x00018E5A File Offset: 0x0001705A
		public unsafe static int ACTION_CONSUMPTION
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_ACTION_CONSUMPTION, (void*)(&value));
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x0012C5E4 File Offset: 0x0012A7E4
		// (set) Token: 0x06002AB5 RID: 10933 RVA: 0x00018E68 File Offset: 0x00017068
		public unsafe static string COMPONENT_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_COMPONENT_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_COMPONENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x0012C604 File Offset: 0x0012A804
		// (set) Token: 0x06002AB7 RID: 10935 RVA: 0x00018E7A File Offset: 0x0001707A
		public unsafe int interactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_interactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_interactCount)) = value;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x0012C62C File Offset: 0x0012A82C
		// (set) Token: 0x06002AB9 RID: 10937 RVA: 0x00018E95 File Offset: 0x00017095
		public unsafe Il2CppReferenceArray<DialogPackage> beginDialogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_beginDialogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_beginDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x0012C65C File Offset: 0x0012A85C
		// (set) Token: 0x06002ABB RID: 10939 RVA: 0x00018EB4 File Offset: 0x000170B4
		public unsafe Il2CppReferenceArray<DialogPackage> runOutOfLotteryDialogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_runOutOfLotteryDialogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_runOutOfLotteryDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x0012C68C File Offset: 0x0012A88C
		// (set) Token: 0x06002ABD RID: 10941 RVA: 0x00018ED3 File Offset: 0x000170D3
		public unsafe Il2CppReferenceArray<DialogPackage> noRewardDialogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_noRewardDialogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_noRewardDialogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x0012C6BC File Offset: 0x0012A8BC
		// (set) Token: 0x06002ABF RID: 10943 RVA: 0x00018EF2 File Offset: 0x000170F2
		public unsafe PlayableAsset conditionFulfilledTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_conditionFulfilledTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_conditionFulfilledTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0012C6EC File Offset: 0x0012A8EC
		// (set) Token: 0x06002AC1 RID: 10945 RVA: 0x00018F11 File Offset: 0x00017111
		public unsafe Il2CppStructArray<MoriyaShrineRewardPair> Rewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_Rewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<MoriyaShrineRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_Rewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x0012C71C File Offset: 0x0012A91C
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x00018F30 File Offset: 0x00017130
		public unsafe Dictionary<MoriyaShrineRewardType, Action> rewardActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_rewardActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MoriyaShrineRewardType, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_rewardActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x0012C74C File Offset: 0x0012A94C
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00018F4F File Offset: 0x0001714F
		public unsafe Il2CppStructArray<int> itemsPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_itemsPercentage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.NativeFieldInfoPtr_itemsPercentage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeFieldInfoPtr_SILVER_COIN_ID;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeFieldInfoPtr_GOLD_COIN_ID;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeFieldInfoPtr_JK_CLOTHES;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeFieldInfoPtr_WIND_BEVERAGE_ID;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeFieldInfoPtr_CONDITION_FULFILLED_COUNT;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeFieldInfoPtr_ACTION_CONSUMPTION;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeFieldInfoPtr_COMPONENT_ID;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeFieldInfoPtr_interactCount;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeFieldInfoPtr_beginDialogs;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_runOutOfLotteryDialogs;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_noRewardDialogs;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr_conditionFulfilledTimeline;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeFieldInfoPtr_Rewards;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr_rewardActions;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeFieldInfoPtr_itemsPercentage;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRewardActions_Private_Void_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_Lottery_Private_Void_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeMethodInfoPtr__Lottery_b__18_1_Private_Void_Action_0;

		// Token: 0x020007BB RID: 1979
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.MoriyaShrineBehaviourComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A550 RID: 42320 RVA: 0x002B2C50 File Offset: 0x002B0E50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr);
				MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, "<>9");
				MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, "<>9__15_0");
				MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, "<>9__17_0");
				MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, "<>9__17_5");
				MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, "<>9__17_6");
				MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, "<>9__17_7");
				MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, "<>9__18_0");
				MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, 100670714);
				MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__OnInitialize_b__15_0_Internal_Single_MoriyaShrineRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, 100670715);
				MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, 100670716);
				MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_5_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, 100670717);
				MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_6_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, 100670718);
				MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_7_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, 100670719);
				MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__Lottery_b__18_0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr, 100670720);
			}

			// Token: 0x0600A551 RID: 42321 RVA: 0x002B2D94 File Offset: 0x002B0F94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A552 RID: 42322 RVA: 0x002B2DD0 File Offset: 0x002B0FD0
			[CallerCount(0)]
			public unsafe float _OnInitialize_b__15_0(MoriyaShrineRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__OnInitialize_b__15_0_Internal_Single_MoriyaShrineRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A553 RID: 42323 RVA: 0x002B2E1C File Offset: 0x002B101C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeRewardActions_b__17_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A554 RID: 42324 RVA: 0x002B2E50 File Offset: 0x002B1050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95401, XrefRangeEnd = 95405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeRewardActions_b__17_5(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_5_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A555 RID: 42325 RVA: 0x002B2EA0 File Offset: 0x002B10A0
			[CallerCount(0)]
			public unsafe int _InitializeRewardActions_b__17_6(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_6_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A556 RID: 42326 RVA: 0x002B2EF0 File Offset: 0x002B10F0
			[CallerCount(0)]
			public unsafe bool _InitializeRewardActions_b__17_7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__InitializeRewardActions_b__17_7_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A557 RID: 42327 RVA: 0x002B2F3C File Offset: 0x002B113C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95405, XrefRangeEnd = 95406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Lottery_b__18_0(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c.NativeMethodInfoPtr__Lottery_b__18_0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A558 RID: 42328 RVA: 0x000596AF File Offset: 0x000578AF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003676 RID: 13942
			// (get) Token: 0x0600A559 RID: 42329 RVA: 0x002B2F80 File Offset: 0x002B1180
			// (set) Token: 0x0600A55A RID: 42330 RVA: 0x000596B8 File Offset: 0x000578B8
			public unsafe static MoriyaShrineBehaviourComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoriyaShrineBehaviourComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003677 RID: 13943
			// (get) Token: 0x0600A55B RID: 42331 RVA: 0x002B2FA8 File Offset: 0x002B11A8
			// (set) Token: 0x0600A55C RID: 42332 RVA: 0x000596CA File Offset: 0x000578CA
			public unsafe static Func<MoriyaShrineRewardPair, float> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MoriyaShrineRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003678 RID: 13944
			// (get) Token: 0x0600A55D RID: 42333 RVA: 0x002B2FD0 File Offset: 0x002B11D0
			// (set) Token: 0x0600A55E RID: 42334 RVA: 0x000596DC File Offset: 0x000578DC
			public unsafe static Action __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003679 RID: 13945
			// (get) Token: 0x0600A55F RID: 42335 RVA: 0x002B2FF8 File Offset: 0x002B11F8
			// (set) Token: 0x0600A560 RID: 42336 RVA: 0x000596EE File Offset: 0x000578EE
			public unsafe static Func<Sellable, bool> __9__17_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700367A RID: 13946
			// (get) Token: 0x0600A561 RID: 42337 RVA: 0x002B3020 File Offset: 0x002B1220
			// (set) Token: 0x0600A562 RID: 42338 RVA: 0x00059700 File Offset: 0x00057900
			public unsafe static Func<Sellable, int> __9__17_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700367B RID: 13947
			// (get) Token: 0x0600A563 RID: 42339 RVA: 0x002B3048 File Offset: 0x002B1248
			// (set) Token: 0x0600A564 RID: 42340 RVA: 0x00059712 File Offset: 0x00057912
			public unsafe static Func<int, bool> __9__17_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__17_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700367C RID: 13948
			// (get) Token: 0x0600A565 RID: 42341 RVA: 0x002B3070 File Offset: 0x002B1270
			// (set) Token: 0x0600A566 RID: 42342 RVA: 0x00059724 File Offset: 0x00057924
			public unsafe static Action<Action> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MoriyaShrineBehaviourComponent.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AE7 RID: 27367
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006AE8 RID: 27368
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04006AE9 RID: 27369
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04006AEA RID: 27370
			private static readonly IntPtr NativeFieldInfoPtr___9__17_5;

			// Token: 0x04006AEB RID: 27371
			private static readonly IntPtr NativeFieldInfoPtr___9__17_6;

			// Token: 0x04006AEC RID: 27372
			private static readonly IntPtr NativeFieldInfoPtr___9__17_7;

			// Token: 0x04006AED RID: 27373
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04006AEE RID: 27374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AEF RID: 27375
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__15_0_Internal_Single_MoriyaShrineRewardPair_0;

			// Token: 0x04006AF0 RID: 27376
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__17_0_Internal_Void_0;

			// Token: 0x04006AF1 RID: 27377
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__17_5_Internal_Boolean_Sellable_0;

			// Token: 0x04006AF2 RID: 27378
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__17_6_Internal_Int32_Sellable_0;

			// Token: 0x04006AF3 RID: 27379
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__17_7_Internal_Boolean_Int32_0;

			// Token: 0x04006AF4 RID: 27380
			private static readonly IntPtr NativeMethodInfoPtr__Lottery_b__18_0_Internal_Void_Action_0;
		}

		// Token: 0x020007BC RID: 1980
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.MoriyaShrineBehaviourComponent+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600A567 RID: 42343 RVA: 0x002B3098 File Offset: 0x002B1298
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr);
				MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr, "pair");
				MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670721);
				MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670722);
				MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670723);
				MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670724);
				MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr, 100670725);
			}

			// Token: 0x0600A568 RID: 42344 RVA: 0x002B313C File Offset: 0x002B133C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A569 RID: 42345 RVA: 0x002B3178 File Offset: 0x002B1378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95406, XrefRangeEnd = 95450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeRewardActions_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A56A RID: 42346 RVA: 0x002B31AC File Offset: 0x002B13AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95450, XrefRangeEnd = 95474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeRewardActions_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A56B RID: 42347 RVA: 0x002B31E0 File Offset: 0x002B13E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95474, XrefRangeEnd = 95478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeRewardActions_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A56C RID: 42348 RVA: 0x002B3214 File Offset: 0x002B1414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95478, XrefRangeEnd = 95482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeRewardActions_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeMethodInfoPtr__InitializeRewardActions_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A56D RID: 42349 RVA: 0x00059736 File Offset: 0x00057936
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700367D RID: 13949
			// (get) Token: 0x0600A56E RID: 42350 RVA: 0x002B3248 File Offset: 0x002B1448
			// (set) Token: 0x0600A56F RID: 42351 RVA: 0x0005973F File Offset: 0x0005793F
			public unsafe MoriyaShrineRewardPair pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_pair);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.__c__DisplayClass17_0.NativeFieldInfoPtr_pair)) = value;
				}
			}

			// Token: 0x04006AF5 RID: 27381
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x04006AF6 RID: 27382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AF7 RID: 27383
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__1_Internal_Void_0;

			// Token: 0x04006AF8 RID: 27384
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__2_Internal_Void_0;

			// Token: 0x04006AF9 RID: 27385
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__3_Internal_Void_0;

			// Token: 0x04006AFA RID: 27386
			private static readonly IntPtr NativeMethodInfoPtr__InitializeRewardActions_b__4_Internal_Void_0;
		}

		// Token: 0x020007BD RID: 1981
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.MoriyaShrineBehaviourComponent+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600A570 RID: 42352 RVA: 0x002B3270 File Offset: 0x002B1470
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass18_0>.NativeClassPtr);
				MoriyaShrineBehaviourComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass18_0>.NativeClassPtr, "x");
				MoriyaShrineBehaviourComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass18_0>.NativeClassPtr, 100670726);
				MoriyaShrineBehaviourComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__Lottery_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass18_0>.NativeClassPtr, 100670727);
			}

			// Token: 0x0600A571 RID: 42353 RVA: 0x002B32D8 File Offset: 0x002B14D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoriyaShrineBehaviourComponent.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A572 RID: 42354 RVA: 0x002B3314 File Offset: 0x002B1514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95482, XrefRangeEnd = 95492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Lottery_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoriyaShrineBehaviourComponent.__c__DisplayClass18_0.NativeMethodInfoPtr__Lottery_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A573 RID: 42355 RVA: 0x0005975A File Offset: 0x0005795A
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700367E RID: 13950
			// (get) Token: 0x0600A574 RID: 42356 RVA: 0x002B3348 File Offset: 0x002B1548
			// (set) Token: 0x0600A575 RID: 42357 RVA: 0x00059763 File Offset: 0x00057963
			public unsafe Action x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoriyaShrineBehaviourComponent.__c__DisplayClass18_0.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006AFB RID: 27387
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04006AFC RID: 27388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006AFD RID: 27389
			private static readonly IntPtr NativeMethodInfoPtr__Lottery_b__2_Internal_Void_0;
		}

		// Token: 0x020007BE RID: 1982
		private sealed class MethodInfoStoreGeneric_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0<T>
		{
			// Token: 0x04006AFE RID: 27390
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MoriyaShrineBehaviourComponent.NativeMethodInfoPtr_PlayDialog_Private_Void_Il2CppArrayBase_1_T_Action_0, Il2CppClassPointerStore<MoriyaShrineBehaviourComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
