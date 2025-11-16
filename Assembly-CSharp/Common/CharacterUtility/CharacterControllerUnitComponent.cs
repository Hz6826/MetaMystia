using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000455 RID: 1109
	public class CharacterControllerUnitComponent : MonoBehaviour
	{
		// Token: 0x06007A95 RID: 31381 RVA: 0x0023524C File Offset: 0x0023344C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterControllerUnitComponent()
		{
			Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "CharacterControllerUnitComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr);
			CharacterControllerUnitComponent.NativeFieldInfoPtr__Ready_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr, "<Ready>k__BackingField");
			CharacterControllerUnitComponent.NativeMethodInfoPtr_get_Ready_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr, 100687874);
			CharacterControllerUnitComponent.NativeMethodInfoPtr_set_Ready_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr, 100687875);
			CharacterControllerUnitComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr, 100687876);
			CharacterControllerUnitComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr, 100687877);
			CharacterControllerUnitComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr, 100687878);
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x06007A96 RID: 31382 RVA: 0x002352F4 File Offset: 0x002334F4
		// (set) Token: 0x06007A97 RID: 31383 RVA: 0x00235330 File Offset: 0x00233530
		public unsafe bool Ready
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnitComponent.NativeMethodInfoPtr_get_Ready_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnitComponent.NativeMethodInfoPtr_set_Ready_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00235370 File Offset: 0x00233570
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnitComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x002353A4 File Offset: 0x002335A4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerUnitComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x002353E0 File Offset: 0x002335E0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterControllerUnitComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterControllerUnitComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnitComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x000422B1 File Offset: 0x000404B1
		public CharacterControllerUnitComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x06007A9C RID: 31388 RVA: 0x0023541C File Offset: 0x0023361C
		// (set) Token: 0x06007A9D RID: 31389 RVA: 0x000422BA File Offset: 0x000404BA
		public unsafe bool _Ready_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnitComponent.NativeFieldInfoPtr__Ready_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnitComponent.NativeFieldInfoPtr__Ready_k__BackingField)) = value;
			}
		}

		// Token: 0x040050A7 RID: 20647
		private static readonly IntPtr NativeFieldInfoPtr__Ready_k__BackingField;

		// Token: 0x040050A8 RID: 20648
		private static readonly IntPtr NativeMethodInfoPtr_get_Ready_Public_get_Boolean_0;

		// Token: 0x040050A9 RID: 20649
		private static readonly IntPtr NativeMethodInfoPtr_set_Ready_Protected_set_Void_Boolean_0;

		// Token: 0x040050AA RID: 20650
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040050AB RID: 20651
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040050AC RID: 20652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
