using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000416 RID: 1046
	public class COM_WorldOverlay_Delete_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060077E1 RID: 30689 RVA: 0x0022D434 File Offset: 0x0022B634
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Delete_Behaviour()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Delete_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Delete_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Delete_Behaviour>.NativeClassPtr);
			COM_WorldOverlay_Delete_Behaviour.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Delete_Behaviour>.NativeClassPtr, "duration");
			COM_WorldOverlay_Delete_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Delete_Behaviour>.NativeClassPtr, "label");
			COM_WorldOverlay_Delete_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Delete_Behaviour>.NativeClassPtr, 100687602);
			COM_WorldOverlay_Delete_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Delete_Behaviour>.NativeClassPtr, 100687603);
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x0022D4B4 File Offset: 0x0022B6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293420, XrefRangeEnd = 293424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Delete_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x0022D4F0 File Offset: 0x0022B6F0
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Delete_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Delete_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Delete_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x00040D3E File Offset: 0x0003EF3E
		public COM_WorldOverlay_Delete_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x060077E5 RID: 30693 RVA: 0x0022D52C File Offset: 0x0022B72C
		// (set) Token: 0x060077E6 RID: 30694 RVA: 0x00040D47 File Offset: 0x0003EF47
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete_Behaviour.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete_Behaviour.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x060077E7 RID: 30695 RVA: 0x0022D554 File Offset: 0x0022B754
		// (set) Token: 0x060077E8 RID: 30696 RVA: 0x00040D62 File Offset: 0x0003EF62
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Delete_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F21 RID: 20257
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04004F22 RID: 20258
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F23 RID: 20259
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F24 RID: 20260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
