using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000425 RID: 1061
	public class COM_ACharacter_Delete_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007872 RID: 30834 RVA: 0x0022EAB4 File Offset: 0x0022CCB4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Delete_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_Delete_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Delete_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Delete_Behaviour>.NativeClassPtr);
			COM_ACharacter_Delete_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Delete_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_Delete_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Delete_Behaviour>.NativeClassPtr, 100687633);
			COM_ACharacter_Delete_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Delete_Behaviour>.NativeClassPtr, 100687634);
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x0022EB20 File Offset: 0x0022CD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293524, XrefRangeEnd = 293529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Delete_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x0022EB5C File Offset: 0x0022CD5C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Delete_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Delete_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Delete_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007875 RID: 30837 RVA: 0x00041277 File Offset: 0x0003F477
		public COM_ACharacter_Delete_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x0022EB98 File Offset: 0x0022CD98
		// (set) Token: 0x06007877 RID: 30839 RVA: 0x00041280 File Offset: 0x0003F480
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Delete_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Delete_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F6A RID: 20330
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F6B RID: 20331
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F6C RID: 20332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
