using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200043E RID: 1086
	public class COM_Items_In_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600794B RID: 31051 RVA: 0x00230ECC File Offset: 0x0022F0CC
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Items_In_Behaviour()
		{
			Il2CppClassPointerStore<COM_Items_In_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Items_In_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Items_In_Behaviour>.NativeClassPtr);
			COM_Items_In_Behaviour.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Items_In_Behaviour>.NativeClassPtr, "items");
			COM_Items_In_Behaviour.NativeFieldInfoPtr_suppressCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Items_In_Behaviour>.NativeClassPtr, "suppressCallbacks");
			COM_Items_In_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_In_Behaviour>.NativeClassPtr, 100687717);
			COM_Items_In_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_In_Behaviour>.NativeClassPtr, 100687718);
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x00230F4C File Offset: 0x0022F14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294054, XrefRangeEnd = 294059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Items_In_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00230F88 File Offset: 0x0022F188
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Items_In_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Items_In_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Items_In_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x00041906 File Offset: 0x0003FB06
		public COM_Items_In_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600794F RID: 31055 RVA: 0x00230FC4 File Offset: 0x0022F1C4
		// (set) Token: 0x06007950 RID: 31056 RVA: 0x0004190F File Offset: 0x0003FB0F
		public unsafe Il2CppReferenceArray<Product> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In_Behaviour.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In_Behaviour.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06007951 RID: 31057 RVA: 0x00230FF4 File Offset: 0x0022F1F4
		// (set) Token: 0x06007952 RID: 31058 RVA: 0x0004192E File Offset: 0x0003FB2E
		public unsafe bool suppressCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In_Behaviour.NativeFieldInfoPtr_suppressCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_In_Behaviour.NativeFieldInfoPtr_suppressCallbacks)) = value;
			}
		}

		// Token: 0x04004FDC RID: 20444
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04004FDD RID: 20445
		private static readonly IntPtr NativeFieldInfoPtr_suppressCallbacks;

		// Token: 0x04004FDE RID: 20446
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FDF RID: 20447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
