using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000324 RID: 804
	public sealed class PartnerInfoKomachi : PartnerInfo
	{
		// Token: 0x06005F29 RID: 24361 RVA: 0x001DB29C File Offset: 0x001D949C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoKomachi()
		{
			Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoKomachi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr);
			PartnerInfoKomachi.NativeFieldInfoPtr_coinEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, "coinEffect");
			PartnerInfoKomachi.NativeFieldInfoPtr_theHandEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, "theHandEffect");
			PartnerInfoKomachi.NativeFieldInfoPtr_workTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, "workTime");
			PartnerInfoKomachi.NativeFieldInfoPtr_sleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, "sleepTime");
			PartnerInfoKomachi.NativeMethodInfoPtr_get_HasWorkSleepLoop_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, 100682836);
			PartnerInfoKomachi.NativeMethodInfoPtr_get_SleepTime_Protected_Virtual_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, 100682837);
			PartnerInfoKomachi.NativeMethodInfoPtr_get_WorkTime_Protected_Virtual_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, 100682838);
			PartnerInfoKomachi.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, 100682839);
			PartnerInfoKomachi.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, 100682840);
			PartnerInfoKomachi.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr, 100682841);
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x001DB394 File Offset: 0x001D9594
		public unsafe override bool HasWorkSleepLoop
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKomachi.NativeMethodInfoPtr_get_HasWorkSleepLoop_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06005F2B RID: 24363 RVA: 0x001DB3D0 File Offset: 0x001D95D0
		public unsafe override Vector2Int SleepTime
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKomachi.NativeMethodInfoPtr_get_SleepTime_Protected_Virtual_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06005F2C RID: 24364 RVA: 0x001DB40C File Offset: 0x001D960C
		public unsafe override Vector2Int WorkTime
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKomachi.NativeMethodInfoPtr_get_WorkTime_Protected_Virtual_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x001DB448 File Offset: 0x001D9648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235170, XrefRangeEnd = 235171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKomachi.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x001DB4C4 File Offset: 0x001D96C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235171, XrefRangeEnd = 235174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKomachi.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x001DB508 File Offset: 0x001D9708
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoKomachi() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoKomachi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoKomachi.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x00033D64 File Offset: 0x00031F64
		public PartnerInfoKomachi(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06005F31 RID: 24369 RVA: 0x001DB544 File Offset: 0x001D9744
		// (set) Token: 0x06005F32 RID: 24370 RVA: 0x00033D6D File Offset: 0x00031F6D
		public unsafe GameObject coinEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_coinEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_coinEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06005F33 RID: 24371 RVA: 0x001DB574 File Offset: 0x001D9774
		// (set) Token: 0x06005F34 RID: 24372 RVA: 0x00033D8C File Offset: 0x00031F8C
		public unsafe GameObject theHandEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_theHandEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_theHandEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06005F35 RID: 24373 RVA: 0x001DB5A4 File Offset: 0x001D97A4
		// (set) Token: 0x06005F36 RID: 24374 RVA: 0x00033DAB File Offset: 0x00031FAB
		public unsafe Vector2Int workTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_workTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_workTime)) = value;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06005F37 RID: 24375 RVA: 0x001DB5CC File Offset: 0x001D97CC
		// (set) Token: 0x06005F38 RID: 24376 RVA: 0x00033DC6 File Offset: 0x00031FC6
		public unsafe Vector2Int sleepTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_sleepTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoKomachi.NativeFieldInfoPtr_sleepTime)) = value;
			}
		}

		// Token: 0x04003EF3 RID: 16115
		private static readonly IntPtr NativeFieldInfoPtr_coinEffect;

		// Token: 0x04003EF4 RID: 16116
		private static readonly IntPtr NativeFieldInfoPtr_theHandEffect;

		// Token: 0x04003EF5 RID: 16117
		private static readonly IntPtr NativeFieldInfoPtr_workTime;

		// Token: 0x04003EF6 RID: 16118
		private static readonly IntPtr NativeFieldInfoPtr_sleepTime;

		// Token: 0x04003EF7 RID: 16119
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWorkSleepLoop_Public_Virtual_get_Boolean_0;

		// Token: 0x04003EF8 RID: 16120
		private static readonly IntPtr NativeMethodInfoPtr_get_SleepTime_Protected_Virtual_get_Vector2Int_0;

		// Token: 0x04003EF9 RID: 16121
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkTime_Protected_Virtual_get_Vector2Int_0;

		// Token: 0x04003EFA RID: 16122
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003EFB RID: 16123
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003EFC RID: 16124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
