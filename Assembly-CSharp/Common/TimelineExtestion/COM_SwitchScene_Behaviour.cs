using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200041B RID: 1051
	public class COM_SwitchScene_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600780B RID: 30731 RVA: 0x0022DAE0 File Offset: 0x0022BCE0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_SwitchScene_Behaviour()
		{
			Il2CppClassPointerStore<COM_SwitchScene_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_SwitchScene_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_SwitchScene_Behaviour>.NativeClassPtr);
			COM_SwitchScene_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SwitchScene_Behaviour>.NativeClassPtr, "label");
			COM_SwitchScene_Behaviour.NativeFieldInfoPtr_sceneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_SwitchScene_Behaviour>.NativeClassPtr, "sceneReference");
			COM_SwitchScene_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SwitchScene_Behaviour>.NativeClassPtr, 100687612);
			COM_SwitchScene_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_SwitchScene_Behaviour>.NativeClassPtr, 100687613);
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x0022DB60 File Offset: 0x0022BD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293446, XrefRangeEnd = 293451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_SwitchScene_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x0022DB9C File Offset: 0x0022BD9C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_SwitchScene_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_SwitchScene_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_SwitchScene_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x00040EB4 File Offset: 0x0003F0B4
		public COM_SwitchScene_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600780F RID: 30735 RVA: 0x0022DBD8 File Offset: 0x0022BDD8
		// (set) Token: 0x06007810 RID: 30736 RVA: 0x00040EBD File Offset: 0x0003F0BD
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x06007811 RID: 30737 RVA: 0x0022DC00 File Offset: 0x0022BE00
		// (set) Token: 0x06007812 RID: 30738 RVA: 0x00040EDC File Offset: 0x0003F0DC
		public unsafe GameObject sceneReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene_Behaviour.NativeFieldInfoPtr_sceneReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_SwitchScene_Behaviour.NativeFieldInfoPtr_sceneReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F36 RID: 20278
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F37 RID: 20279
		private static readonly IntPtr NativeFieldInfoPtr_sceneReference;

		// Token: 0x04004F38 RID: 20280
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F39 RID: 20281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
