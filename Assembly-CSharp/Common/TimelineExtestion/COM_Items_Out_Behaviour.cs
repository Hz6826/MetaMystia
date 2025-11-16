using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200043F RID: 1087
	public class COM_Items_Out_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007953 RID: 31059 RVA: 0x0023101C File Offset: 0x0022F21C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Items_Out_Behaviour()
		{
			Il2CppClassPointerStore<COM_Items_Out_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Items_Out_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Items_Out_Behaviour>.NativeClassPtr);
			COM_Items_Out_Behaviour.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Items_Out_Behaviour>.NativeClassPtr, "items");
			COM_Items_Out_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_Out_Behaviour>.NativeClassPtr, 100687719);
			COM_Items_Out_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Items_Out_Behaviour>.NativeClassPtr, 100687720);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x00231088 File Offset: 0x0022F288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294059, XrefRangeEnd = 294064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Items_Out_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x002310C4 File Offset: 0x0022F2C4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Items_Out_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Items_Out_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Items_Out_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x00041949 File Offset: 0x0003FB49
		public COM_Items_Out_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x06007957 RID: 31063 RVA: 0x00231100 File Offset: 0x0022F300
		// (set) Token: 0x06007958 RID: 31064 RVA: 0x00041952 File Offset: 0x0003FB52
		public unsafe Il2CppReferenceArray<Product> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_Out_Behaviour.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Items_Out_Behaviour.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FE0 RID: 20448
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04004FE1 RID: 20449
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FE2 RID: 20450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
