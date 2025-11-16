using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000426 RID: 1062
	public class COM_UI_OpenPannel_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007878 RID: 30840 RVA: 0x0022EBC0 File Offset: 0x0022CDC0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_UI_OpenPannel_Behaviour()
		{
			Il2CppClassPointerStore<COM_UI_OpenPannel_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_UI_OpenPannel_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_UI_OpenPannel_Behaviour>.NativeClassPtr);
			COM_UI_OpenPannel_Behaviour.NativeFieldInfoPtr_pannelGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_UI_OpenPannel_Behaviour>.NativeClassPtr, "pannelGameObject");
			COM_UI_OpenPannel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_OpenPannel_Behaviour>.NativeClassPtr, 100687635);
			COM_UI_OpenPannel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_OpenPannel_Behaviour>.NativeClassPtr, 100687636);
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x0022EC2C File Offset: 0x0022CE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293529, XrefRangeEnd = 293540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_UI_OpenPannel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x0022EC68 File Offset: 0x0022CE68
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_UI_OpenPannel_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_UI_OpenPannel_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_UI_OpenPannel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x0004129F File Offset: 0x0003F49F
		public COM_UI_OpenPannel_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600787C RID: 30844 RVA: 0x0022ECA4 File Offset: 0x0022CEA4
		// (set) Token: 0x0600787D RID: 30845 RVA: 0x000412A8 File Offset: 0x0003F4A8
		public unsafe GameObject pannelGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_UI_OpenPannel_Behaviour.NativeFieldInfoPtr_pannelGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_UI_OpenPannel_Behaviour.NativeFieldInfoPtr_pannelGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F6D RID: 20333
		private static readonly IntPtr NativeFieldInfoPtr_pannelGameObject;

		// Token: 0x04004F6E RID: 20334
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F6F RID: 20335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
