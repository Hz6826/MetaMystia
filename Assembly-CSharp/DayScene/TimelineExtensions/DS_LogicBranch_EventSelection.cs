using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000151 RID: 337
	public class DS_LogicBranch_EventSelection : PlayableAsset
	{
		// Token: 0x060026FD RID: 9981 RVA: 0x00120B18 File Offset: 0x0011ED18
		// Note: this type is marked as 'beforefieldinit'.
		static DS_LogicBranch_EventSelection()
		{
			Il2CppClassPointerStore<DS_LogicBranch_EventSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_LogicBranch_EventSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_LogicBranch_EventSelection>.NativeClassPtr);
			DS_LogicBranch_EventSelection.NativeFieldInfoPtr_eventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_EventSelection>.NativeClassPtr, "eventOptions");
			DS_LogicBranch_EventSelection.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_EventSelection>.NativeClassPtr, 100670238);
			DS_LogicBranch_EventSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_EventSelection>.NativeClassPtr, 100670239);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00120B84 File Offset: 0x0011ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90726, XrefRangeEnd = 90739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_LogicBranch_EventSelection.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00120BEC File Offset: 0x0011EDEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_LogicBranch_EventSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_LogicBranch_EventSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_LogicBranch_EventSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x00016FAF File Offset: 0x000151AF
		public DS_LogicBranch_EventSelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x00120C28 File Offset: 0x0011EE28
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x00016FB8 File Offset: 0x000151B8
		public unsafe Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption> eventOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection.NativeFieldInfoPtr_eventOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection.NativeFieldInfoPtr_eventOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeFieldInfoPtr_eventOptions;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000786 RID: 1926
		[Serializable]
		public sealed class EventOption : ValueType
		{
			// Token: 0x0600A300 RID: 41728 RVA: 0x002AC6C4 File Offset: 0x002AA8C4
			// Note: this type is marked as 'beforefieldinit'.
			static EventOption()
			{
				Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DS_LogicBranch_EventSelection>.NativeClassPtr, "EventOption");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr);
				DS_LogicBranch_EventSelection.EventOption.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr, "Title");
				DS_LogicBranch_EventSelection.EventOption.NativeFieldInfoPtr_AddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr, "AddFrames");
			}

			// Token: 0x0600A301 RID: 41729 RVA: 0x0005812F File Offset: 0x0005632F
			public EventOption(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A302 RID: 41730 RVA: 0x00058138 File Offset: 0x00056338
			public EventOption() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr))
			{
			}

			// Token: 0x170035C8 RID: 13768
			// (get) Token: 0x0600A303 RID: 41731 RVA: 0x002AC718 File Offset: 0x002AA918
			// (set) Token: 0x0600A304 RID: 41732 RVA: 0x0005814A File Offset: 0x0005634A
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection.EventOption.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection.EventOption.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170035C9 RID: 13769
			// (get) Token: 0x0600A305 RID: 41733 RVA: 0x002AC740 File Offset: 0x002AA940
			// (set) Token: 0x0600A306 RID: 41734 RVA: 0x00058169 File Offset: 0x00056369
			public unsafe int AddFrames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection.EventOption.NativeFieldInfoPtr_AddFrames);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection.EventOption.NativeFieldInfoPtr_AddFrames)) = value;
				}
			}

			// Token: 0x04006988 RID: 27016
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x04006989 RID: 27017
			private static readonly IntPtr NativeFieldInfoPtr_AddFrames;
		}
	}
}
