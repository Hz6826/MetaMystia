using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200041C RID: 1052
	public class COM_ACharacter_SpawnOrSetPosition_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007813 RID: 30739 RVA: 0x0022DC30 File Offset: 0x0022BE30
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SpawnOrSetPosition_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SpawnOrSetPosition_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr);
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_characterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, "characterId");
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_characterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, "characterType");
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_identifierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, "identifierLabel");
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_positionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, "positionLabel");
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, "startPosition");
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_usePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, "usePosition");
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, 100687614);
			COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr, 100687615);
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x0022DD00 File Offset: 0x0022BF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293451, XrefRangeEnd = 293455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x0022DD3C File Offset: 0x0022BF3C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SpawnOrSetPosition_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetPosition_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00040EFB File Offset: 0x0003F0FB
		public COM_ACharacter_SpawnOrSetPosition_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x06007817 RID: 30743 RVA: 0x0022DD78 File Offset: 0x0022BF78
		// (set) Token: 0x06007818 RID: 30744 RVA: 0x00040F04 File Offset: 0x0003F104
		public unsafe int characterId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_characterId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_characterId)) = value;
			}
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x06007819 RID: 30745 RVA: 0x0022DDA0 File Offset: 0x0022BFA0
		// (set) Token: 0x0600781A RID: 30746 RVA: 0x00040F1F File Offset: 0x0003F11F
		public unsafe SceneDirector.Identity characterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_characterType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_characterType)) = value;
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600781B RID: 30747 RVA: 0x0022DDC8 File Offset: 0x0022BFC8
		// (set) Token: 0x0600781C RID: 30748 RVA: 0x00040F3A File Offset: 0x0003F13A
		public unsafe string identifierLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_identifierLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_identifierLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600781D RID: 30749 RVA: 0x0022DDF0 File Offset: 0x0022BFF0
		// (set) Token: 0x0600781E RID: 30750 RVA: 0x00040F59 File Offset: 0x0003F159
		public unsafe string positionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_positionLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_positionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600781F RID: 30751 RVA: 0x0022DE18 File Offset: 0x0022C018
		// (set) Token: 0x06007820 RID: 30752 RVA: 0x00040F78 File Offset: 0x0003F178
		public unsafe Vector2 startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x06007821 RID: 30753 RVA: 0x0022DE40 File Offset: 0x0022C040
		// (set) Token: 0x06007822 RID: 30754 RVA: 0x00040F93 File Offset: 0x0003F193
		public unsafe bool usePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_usePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetPosition_Behaviour.NativeFieldInfoPtr_usePosition)) = value;
			}
		}

		// Token: 0x04004F3A RID: 20282
		private static readonly IntPtr NativeFieldInfoPtr_characterId;

		// Token: 0x04004F3B RID: 20283
		private static readonly IntPtr NativeFieldInfoPtr_characterType;

		// Token: 0x04004F3C RID: 20284
		private static readonly IntPtr NativeFieldInfoPtr_identifierLabel;

		// Token: 0x04004F3D RID: 20285
		private static readonly IntPtr NativeFieldInfoPtr_positionLabel;

		// Token: 0x04004F3E RID: 20286
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x04004F3F RID: 20287
		private static readonly IntPtr NativeFieldInfoPtr_usePosition;

		// Token: 0x04004F40 RID: 20288
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F41 RID: 20289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
