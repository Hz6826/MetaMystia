using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003EC RID: 1004
	public class COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc : PlayableAsset
	{
		// Token: 0x06007694 RID: 30356 RVA: 0x002296D4 File Offset: 0x002278D4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc()
		{
			Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr);
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_characterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, "characterType");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_characterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, "characterId");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_targetCharacterStringKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, "targetCharacterStringKey");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_targetCharacterOverrideRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, "targetCharacterOverrideRotation");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, "distance");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_identifierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, "identifierLabel");
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, 100687515);
			COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr, 100687516);
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x002297A4 File Offset: 0x002279A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292807, XrefRangeEnd = 292821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x0022980C File Offset: 0x00227A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292821, XrefRangeEnd = 292822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x000402A9 File Offset: 0x0003E4A9
		public COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x06007698 RID: 30360 RVA: 0x00229848 File Offset: 0x00227A48
		// (set) Token: 0x06007699 RID: 30361 RVA: 0x000402B2 File Offset: 0x0003E4B2
		public unsafe SceneDirector.Identity characterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_characterType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_characterType)) = value;
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x0600769A RID: 30362 RVA: 0x00229870 File Offset: 0x00227A70
		// (set) Token: 0x0600769B RID: 30363 RVA: 0x000402CD File Offset: 0x0003E4CD
		public unsafe int characterId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_characterId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_characterId)) = value;
			}
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600769C RID: 30364 RVA: 0x00229898 File Offset: 0x00227A98
		// (set) Token: 0x0600769D RID: 30365 RVA: 0x000402E8 File Offset: 0x0003E4E8
		public unsafe string targetCharacterStringKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_targetCharacterStringKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_targetCharacterStringKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600769E RID: 30366 RVA: 0x002298C0 File Offset: 0x00227AC0
		// (set) Token: 0x0600769F RID: 30367 RVA: 0x00040307 File Offset: 0x0003E507
		public unsafe DayScenePlayerInputGenerator.CharacterRotation targetCharacterOverrideRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_targetCharacterOverrideRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_targetCharacterOverrideRotation)) = value;
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x060076A0 RID: 30368 RVA: 0x002298E8 File Offset: 0x00227AE8
		// (set) Token: 0x060076A1 RID: 30369 RVA: 0x00040322 File Offset: 0x0003E522
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x060076A2 RID: 30370 RVA: 0x00229910 File Offset: 0x00227B10
		// (set) Token: 0x060076A3 RID: 30371 RVA: 0x0004033D File Offset: 0x0003E53D
		public unsafe string identifierLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_identifierLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc.NativeFieldInfoPtr_identifierLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004E79 RID: 20089
		private static readonly IntPtr NativeFieldInfoPtr_characterType;

		// Token: 0x04004E7A RID: 20090
		private static readonly IntPtr NativeFieldInfoPtr_characterId;

		// Token: 0x04004E7B RID: 20091
		private static readonly IntPtr NativeFieldInfoPtr_targetCharacterStringKey;

		// Token: 0x04004E7C RID: 20092
		private static readonly IntPtr NativeFieldInfoPtr_targetCharacterOverrideRotation;

		// Token: 0x04004E7D RID: 20093
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04004E7E RID: 20094
		private static readonly IntPtr NativeFieldInfoPtr_identifierLabel;

		// Token: 0x04004E7F RID: 20095
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E80 RID: 20096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
