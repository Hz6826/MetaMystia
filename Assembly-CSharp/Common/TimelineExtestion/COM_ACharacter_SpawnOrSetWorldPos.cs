using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003EB RID: 1003
	public class COM_ACharacter_SpawnOrSetWorldPos : PlayableAsset
	{
		// Token: 0x06007684 RID: 30340 RVA: 0x00229470 File Offset: 0x00227670
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SpawnOrSetWorldPos()
		{
			Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SpawnOrSetWorldPos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr);
			COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_characterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, "characterType");
			COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_characterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, "characterId");
			COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, "startPosition");
			COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_identifierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, "identifierLabel");
			COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_usePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, "usePosition");
			COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_positionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, "positionLabel");
			COM_ACharacter_SpawnOrSetWorldPos.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, 100687513);
			COM_ACharacter_SpawnOrSetWorldPos.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr, 100687514);
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00229540 File Offset: 0x00227740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292793, XrefRangeEnd = 292807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SpawnOrSetWorldPos.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x002295A8 File Offset: 0x002277A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SpawnOrSetWorldPos() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SpawnOrSetWorldPos>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SpawnOrSetWorldPos.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x000401F6 File Offset: 0x0003E3F6
		public COM_ACharacter_SpawnOrSetWorldPos(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x06007688 RID: 30344 RVA: 0x002295E4 File Offset: 0x002277E4
		// (set) Token: 0x06007689 RID: 30345 RVA: 0x000401FF File Offset: 0x0003E3FF
		public unsafe SceneDirector.Identity characterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_characterType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_characterType)) = value;
			}
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x0022960C File Offset: 0x0022780C
		// (set) Token: 0x0600768B RID: 30347 RVA: 0x0004021A File Offset: 0x0003E41A
		public unsafe int characterId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_characterId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_characterId)) = value;
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600768C RID: 30348 RVA: 0x00229634 File Offset: 0x00227834
		// (set) Token: 0x0600768D RID: 30349 RVA: 0x00040235 File Offset: 0x0003E435
		public unsafe Vector2 startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x0600768E RID: 30350 RVA: 0x0022965C File Offset: 0x0022785C
		// (set) Token: 0x0600768F RID: 30351 RVA: 0x00040250 File Offset: 0x0003E450
		public unsafe string identifierLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_identifierLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_identifierLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x06007690 RID: 30352 RVA: 0x00229684 File Offset: 0x00227884
		// (set) Token: 0x06007691 RID: 30353 RVA: 0x0004026F File Offset: 0x0003E46F
		public unsafe bool usePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_usePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_usePosition)) = value;
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x06007692 RID: 30354 RVA: 0x002296AC File Offset: 0x002278AC
		// (set) Token: 0x06007693 RID: 30355 RVA: 0x0004028A File Offset: 0x0003E48A
		public unsafe string positionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_positionLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SpawnOrSetWorldPos.NativeFieldInfoPtr_positionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004E71 RID: 20081
		private static readonly IntPtr NativeFieldInfoPtr_characterType;

		// Token: 0x04004E72 RID: 20082
		private static readonly IntPtr NativeFieldInfoPtr_characterId;

		// Token: 0x04004E73 RID: 20083
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x04004E74 RID: 20084
		private static readonly IntPtr NativeFieldInfoPtr_identifierLabel;

		// Token: 0x04004E75 RID: 20085
		private static readonly IntPtr NativeFieldInfoPtr_usePosition;

		// Token: 0x04004E76 RID: 20086
		private static readonly IntPtr NativeFieldInfoPtr_positionLabel;

		// Token: 0x04004E77 RID: 20087
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E78 RID: 20088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
