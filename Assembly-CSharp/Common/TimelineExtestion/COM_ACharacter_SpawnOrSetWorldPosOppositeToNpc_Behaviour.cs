using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x0200041D RID: 1053
	public class COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007823 RID: 30755 RVA: 0x0022DE68 File Offset: 0x0022C068
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr);
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_characterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, "characterId");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_characterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, "characterType");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, "distance");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_identifierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, "identifierLabel");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_targetCharacterOverrideRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, "targetCharacterOverrideRotation");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_targetCharacterStringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, "targetCharacterStringKey");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, 100687616);
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeMethodInfoPtr_GetOppositeRotation_Private_CharacterRotation_CharacterRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, 100687617);
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr, 100687618);
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x0022DF4C File Offset: 0x0022C14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293455, XrefRangeEnd = 293483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x0022DF88 File Offset: 0x0022C188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293483, XrefRangeEnd = 293486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DayScenePlayerInputGenerator.CharacterRotation GetOppositeRotation(DayScenePlayerInputGenerator.CharacterRotation rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeMethodInfoPtr_GetOppositeRotation_Private_CharacterRotation_CharacterRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x0022DFD4 File Offset: 0x0022C1D4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00040FAE File Offset: 0x0003F1AE
		public COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x06007828 RID: 30760 RVA: 0x0022E010 File Offset: 0x0022C210
		// (set) Token: 0x06007829 RID: 30761 RVA: 0x00040FB7 File Offset: 0x0003F1B7
		public unsafe int characterId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_characterId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_characterId)) = value;
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x0600782A RID: 30762 RVA: 0x0022E038 File Offset: 0x0022C238
		// (set) Token: 0x0600782B RID: 30763 RVA: 0x00040FD2 File Offset: 0x0003F1D2
		public unsafe SceneDirector.Identity characterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_characterType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_characterType)) = value;
			}
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x0022E060 File Offset: 0x0022C260
		// (set) Token: 0x0600782D RID: 30765 RVA: 0x00040FED File Offset: 0x0003F1ED
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x0022E088 File Offset: 0x0022C288
		// (set) Token: 0x0600782F RID: 30767 RVA: 0x00041008 File Offset: 0x0003F208
		public unsafe string identifierLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_identifierLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_identifierLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x0022E0B0 File Offset: 0x0022C2B0
		// (set) Token: 0x06007831 RID: 30769 RVA: 0x00041027 File Offset: 0x0003F227
		public unsafe DayScenePlayerInputGenerator.CharacterRotation targetCharacterOverrideRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_targetCharacterOverrideRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_targetCharacterOverrideRotation)) = value;
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x06007832 RID: 30770 RVA: 0x0022E0D8 File Offset: 0x0022C2D8
		// (set) Token: 0x06007833 RID: 30771 RVA: 0x00041042 File Offset: 0x0003F242
		public unsafe string targetCharacterStringKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_targetCharacterStringKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour.NativeFieldInfoPtr_targetCharacterStringKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F42 RID: 20290
		private static readonly IntPtr NativeFieldInfoPtr_characterId;

		// Token: 0x04004F43 RID: 20291
		private static readonly IntPtr NativeFieldInfoPtr_characterType;

		// Token: 0x04004F44 RID: 20292
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04004F45 RID: 20293
		private static readonly IntPtr NativeFieldInfoPtr_identifierLabel;

		// Token: 0x04004F46 RID: 20294
		private static readonly IntPtr NativeFieldInfoPtr_targetCharacterOverrideRotation;

		// Token: 0x04004F47 RID: 20295
		private static readonly IntPtr NativeFieldInfoPtr_targetCharacterStringKey;

		// Token: 0x04004F48 RID: 20296
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F49 RID: 20297
		private static readonly IntPtr NativeMethodInfoPtr_GetOppositeRotation_Private_CharacterRotation_CharacterRotation_0;

		// Token: 0x04004F4A RID: 20298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
