using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI.GlobalMap
{
	// Token: 0x020003D4 RID: 980
	public class GuideMapController : MonoBehaviour
	{
		// Token: 0x060074ED RID: 29933 RVA: 0x002241A0 File Offset: 0x002223A0
		// Note: this type is marked as 'beforefieldinit'.
		static GuideMapController()
		{
			Il2CppClassPointerStore<GuideMapController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.GlobalMap", "GuideMapController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr);
			GuideMapController.NativeFieldInfoPtr_m_MapConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "m_MapConnections");
			GuideMapController.NativeFieldInfoPtr_m_GlobalSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "m_GlobalSpots");
			GuideMapController.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "m_Button");
			GuideMapController.NativeFieldInfoPtr_m_MapDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "m_MapDictionary");
			GuideMapController.NativeFieldInfoPtr_m_NodeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "m_NodeMap");
			GuideMapController.NativeFieldInfoPtr_m_GlobalSpotSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "m_GlobalSpotSet");
			GuideMapController.NativeFieldInfoPtr_m_GuideMapSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "m_GuideMapSpots");
			GuideMapController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687312);
			GuideMapController.NativeMethodInfoPtr_add_OnPointerDownCallback_Public_add_Void_Action_2_InputButton_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687313);
			GuideMapController.NativeMethodInfoPtr_remove_OnPointerDownCallback_Public_rem_Void_Action_2_InputButton_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687314);
			GuideMapController.NativeMethodInfoPtr_add_OnPointerDragCallback_Public_add_Void_Action_3_InputButton_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687315);
			GuideMapController.NativeMethodInfoPtr_remove_OnPointerDragCallback_Public_rem_Void_Action_3_InputButton_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687316);
			GuideMapController.NativeMethodInfoPtr_GetSpotList_Public_IReadOnlyList_1_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687317);
			GuideMapController.NativeMethodInfoPtr_GetTravelCount_Public_Int32_IGuideMapSpot_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687318);
			GuideMapController.NativeMethodInfoPtr_GetNeighbourDistance_Public_IReadOnlyDictionary_2_GuideMapSpot_Int32_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687319);
			GuideMapController.NativeMethodInfoPtr_UpdateGuideMapVisual_Public_Void_Predicate_1_IGuideMapSpot_Func_3_IGuideMapSpot_IGuideMapSpot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687320);
			GuideMapController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, 100687321);
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x00224324 File Offset: 0x00222524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290873, XrefRangeEnd = 290984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x00224358 File Offset: 0x00222558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290986, RefRangeEnd = 290988, XrefRangeStart = 290984, XrefRangeEnd = 290986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnPointerDownCallback(Action<PointerEventData.InputButton, Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_add_OnPointerDownCallback_Public_add_Void_Action_2_InputButton_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x0022439C File Offset: 0x0022259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290988, XrefRangeEnd = 290990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnPointerDownCallback(Action<PointerEventData.InputButton, Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_remove_OnPointerDownCallback_Public_rem_Void_Action_2_InputButton_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x002243E0 File Offset: 0x002225E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290992, RefRangeEnd = 290994, XrefRangeStart = 290990, XrefRangeEnd = 290992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnPointerDragCallback(Action<PointerEventData.InputButton, Vector2, Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_add_OnPointerDragCallback_Public_add_Void_Action_3_InputButton_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00224424 File Offset: 0x00222624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290994, XrefRangeEnd = 290996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnPointerDragCallback(Action<PointerEventData.InputButton, Vector2, Vector2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_remove_OnPointerDragCallback_Public_rem_Void_Action_3_InputButton_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00224468 File Offset: 0x00222668
		[CallerCount(0)]
		public unsafe IReadOnlyList<IGuideMapSpot> GetSpotList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_GetSpotList_Public_IReadOnlyList_1_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IGuideMapSpot>>(intPtr3) : null;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x002244A8 File Offset: 0x002226A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 291018, RefRangeEnd = 291024, XrefRangeStart = 290996, XrefRangeEnd = 291018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTravelCount(IGuideMapSpot from, IGuideMapSpot to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_GetTravelCount_Public_Int32_IGuideMapSpot_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00224508 File Offset: 0x00222708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291072, RefRangeEnd = 291073, XrefRangeStart = 291024, XrefRangeEnd = 291072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyDictionary<GuideMapSpot, int> GetNeighbourDistance(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_GetNeighbourDistance_Public_IReadOnlyDictionary_2_GuideMapSpot_Int32_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<GuideMapSpot, int>>(intPtr3) : null;
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00224558 File Offset: 0x00222758
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 291119, RefRangeEnd = 291125, XrefRangeStart = 291073, XrefRangeEnd = 291119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGuideMapVisual(Predicate<IGuideMapSpot> activateHandler, Func<IGuideMapSpot, IGuideMapSpot, bool> showPathHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(activateHandler);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(showPathHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr_UpdateGuideMapVisual_Public_Void_Predicate_1_IGuideMapSpot_Func_3_IGuideMapSpot_IGuideMapSpot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x002245AC File Offset: 0x002227AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291125, XrefRangeEnd = 291134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuideMapController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x0003F4AA File Offset: 0x0003D6AA
		public GuideMapController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x060074F9 RID: 29945 RVA: 0x002245E8 File Offset: 0x002227E8
		// (set) Token: 0x060074FA RID: 29946 RVA: 0x0003F4B3 File Offset: 0x0003D6B3
		public unsafe Il2CppReferenceArray<GuideMapController.MapConnection> m_MapConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_MapConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuideMapController.MapConnection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_MapConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x060074FB RID: 29947 RVA: 0x00224618 File Offset: 0x00222818
		// (set) Token: 0x060074FC RID: 29948 RVA: 0x0003F4D2 File Offset: 0x0003D6D2
		public unsafe Il2CppReferenceArray<GuideMapSpot> m_GlobalSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_GlobalSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuideMapSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_GlobalSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x060074FD RID: 29949 RVA: 0x00224648 File Offset: 0x00222848
		// (set) Token: 0x060074FE RID: 29950 RVA: 0x0003F4F1 File Offset: 0x0003D6F1
		public unsafe UIButtonSimple m_Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x060074FF RID: 29951 RVA: 0x00224678 File Offset: 0x00222878
		// (set) Token: 0x06007500 RID: 29952 RVA: 0x0003F510 File Offset: 0x0003D710
		public unsafe Dictionary<GuideMapSpot, Dijkstra.DijkstraNode<GuideMapSpot>> m_MapDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_MapDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GuideMapSpot, Dijkstra.DijkstraNode<GuideMapSpot>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_MapDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x06007501 RID: 29953 RVA: 0x002246A8 File Offset: 0x002228A8
		// (set) Token: 0x06007502 RID: 29954 RVA: 0x0003F52F File Offset: 0x0003D72F
		public unsafe HashSet<Dijkstra.DijkstraNode<GuideMapSpot>> m_NodeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_NodeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Dijkstra.DijkstraNode<GuideMapSpot>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_NodeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x06007503 RID: 29955 RVA: 0x002246D8 File Offset: 0x002228D8
		// (set) Token: 0x06007504 RID: 29956 RVA: 0x0003F54E File Offset: 0x0003D74E
		public unsafe HashSet<GuideMapSpot> m_GlobalSpotSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_GlobalSpotSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GuideMapSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_GlobalSpotSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x00224708 File Offset: 0x00222908
		// (set) Token: 0x06007506 RID: 29958 RVA: 0x0003F56D File Offset: 0x0003D76D
		public unsafe List<GuideMapSpot> m_GuideMapSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_GuideMapSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuideMapSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.NativeFieldInfoPtr_m_GuideMapSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D76 RID: 19830
		private static readonly IntPtr NativeFieldInfoPtr_m_MapConnections;

		// Token: 0x04004D77 RID: 19831
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalSpots;

		// Token: 0x04004D78 RID: 19832
		private static readonly IntPtr NativeFieldInfoPtr_m_Button;

		// Token: 0x04004D79 RID: 19833
		private static readonly IntPtr NativeFieldInfoPtr_m_MapDictionary;

		// Token: 0x04004D7A RID: 19834
		private static readonly IntPtr NativeFieldInfoPtr_m_NodeMap;

		// Token: 0x04004D7B RID: 19835
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalSpotSet;

		// Token: 0x04004D7C RID: 19836
		private static readonly IntPtr NativeFieldInfoPtr_m_GuideMapSpots;

		// Token: 0x04004D7D RID: 19837
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D7E RID: 19838
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPointerDownCallback_Public_add_Void_Action_2_InputButton_Vector2_0;

		// Token: 0x04004D7F RID: 19839
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPointerDownCallback_Public_rem_Void_Action_2_InputButton_Vector2_0;

		// Token: 0x04004D80 RID: 19840
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPointerDragCallback_Public_add_Void_Action_3_InputButton_Vector2_Vector2_0;

		// Token: 0x04004D81 RID: 19841
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPointerDragCallback_Public_rem_Void_Action_3_InputButton_Vector2_Vector2_0;

		// Token: 0x04004D82 RID: 19842
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotList_Public_IReadOnlyList_1_IGuideMapSpot_0;

		// Token: 0x04004D83 RID: 19843
		private static readonly IntPtr NativeMethodInfoPtr_GetTravelCount_Public_Int32_IGuideMapSpot_IGuideMapSpot_0;

		// Token: 0x04004D84 RID: 19844
		private static readonly IntPtr NativeMethodInfoPtr_GetNeighbourDistance_Public_IReadOnlyDictionary_2_GuideMapSpot_Int32_IGuideMapSpot_0;

		// Token: 0x04004D85 RID: 19845
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGuideMapVisual_Public_Void_Predicate_1_IGuideMapSpot_Func_3_IGuideMapSpot_IGuideMapSpot_Boolean_0;

		// Token: 0x04004D86 RID: 19846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F72 RID: 3954
		[Serializable]
		public class MapConnection : Il2CppSystem.Object
		{
			// Token: 0x060112BE RID: 70334 RVA: 0x003F5980 File Offset: 0x003F3B80
			// Note: this type is marked as 'beforefieldinit'.
			static MapConnection()
			{
				Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "MapConnection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr);
				GuideMapController.MapConnection.NativeFieldInfoPtr__SourceSpot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, "<SourceSpot>k__BackingField");
				GuideMapController.MapConnection.NativeFieldInfoPtr__TargetSpot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, "<TargetSpot>k__BackingField");
				GuideMapController.MapConnection.NativeFieldInfoPtr__PathVisual_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, "<PathVisual>k__BackingField");
				GuideMapController.MapConnection.NativeMethodInfoPtr_get_SourceSpot_Public_get_GuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, 100687322);
				GuideMapController.MapConnection.NativeMethodInfoPtr_set_SourceSpot_Private_set_Void_GuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, 100687323);
				GuideMapController.MapConnection.NativeMethodInfoPtr_get_TargetSpot_Public_get_GuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, 100687324);
				GuideMapController.MapConnection.NativeMethodInfoPtr_set_TargetSpot_Private_set_Void_GuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, 100687325);
				GuideMapController.MapConnection.NativeMethodInfoPtr_get_PathVisual_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, 100687326);
				GuideMapController.MapConnection.NativeMethodInfoPtr_set_PathVisual_Private_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, 100687327);
				GuideMapController.MapConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr, 100687328);
			}

			// Token: 0x17005942 RID: 22850
			// (get) Token: 0x060112BF RID: 70335 RVA: 0x003F5A74 File Offset: 0x003F3C74
			// (set) Token: 0x060112C0 RID: 70336 RVA: 0x003F5AB4 File Offset: 0x003F3CB4
			public unsafe GuideMapSpot SourceSpot
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.MapConnection.NativeMethodInfoPtr_get_SourceSpot_Public_get_GuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr3) : null;
				}
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.MapConnection.NativeMethodInfoPtr_set_SourceSpot_Private_set_Void_GuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17005943 RID: 22851
			// (get) Token: 0x060112C1 RID: 70337 RVA: 0x003F5AF8 File Offset: 0x003F3CF8
			// (set) Token: 0x060112C2 RID: 70338 RVA: 0x003F5B38 File Offset: 0x003F3D38
			public unsafe GuideMapSpot TargetSpot
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.MapConnection.NativeMethodInfoPtr_get_TargetSpot_Public_get_GuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.MapConnection.NativeMethodInfoPtr_set_TargetSpot_Private_set_Void_GuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17005944 RID: 22852
			// (get) Token: 0x060112C3 RID: 70339 RVA: 0x003F5B7C File Offset: 0x003F3D7C
			// (set) Token: 0x060112C4 RID: 70340 RVA: 0x003F5BBC File Offset: 0x003F3DBC
			public unsafe Image PathVisual
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.MapConnection.NativeMethodInfoPtr_get_PathVisual_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.MapConnection.NativeMethodInfoPtr_set_PathVisual_Private_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060112C5 RID: 70341 RVA: 0x003F5C00 File Offset: 0x003F3E00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MapConnection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapController.MapConnection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.MapConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112C6 RID: 70342 RVA: 0x000954FC File Offset: 0x000936FC
			public MapConnection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700593F RID: 22847
			// (get) Token: 0x060112C7 RID: 70343 RVA: 0x003F5C3C File Offset: 0x003F3E3C
			// (set) Token: 0x060112C8 RID: 70344 RVA: 0x00095505 File Offset: 0x00093705
			public unsafe GuideMapSpot _SourceSpot_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.MapConnection.NativeFieldInfoPtr__SourceSpot_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.MapConnection.NativeFieldInfoPtr__SourceSpot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005940 RID: 22848
			// (get) Token: 0x060112C9 RID: 70345 RVA: 0x003F5C6C File Offset: 0x003F3E6C
			// (set) Token: 0x060112CA RID: 70346 RVA: 0x00095524 File Offset: 0x00093724
			public unsafe GuideMapSpot _TargetSpot_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.MapConnection.NativeFieldInfoPtr__TargetSpot_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.MapConnection.NativeFieldInfoPtr__TargetSpot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005941 RID: 22849
			// (get) Token: 0x060112CB RID: 70347 RVA: 0x003F5C9C File Offset: 0x003F3E9C
			// (set) Token: 0x060112CC RID: 70348 RVA: 0x00095543 File Offset: 0x00093743
			public unsafe Image _PathVisual_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.MapConnection.NativeFieldInfoPtr__PathVisual_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.MapConnection.NativeFieldInfoPtr__PathVisual_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADA8 RID: 44456
			private static readonly IntPtr NativeFieldInfoPtr__SourceSpot_k__BackingField;

			// Token: 0x0400ADA9 RID: 44457
			private static readonly IntPtr NativeFieldInfoPtr__TargetSpot_k__BackingField;

			// Token: 0x0400ADAA RID: 44458
			private static readonly IntPtr NativeFieldInfoPtr__PathVisual_k__BackingField;

			// Token: 0x0400ADAB RID: 44459
			private static readonly IntPtr NativeMethodInfoPtr_get_SourceSpot_Public_get_GuideMapSpot_0;

			// Token: 0x0400ADAC RID: 44460
			private static readonly IntPtr NativeMethodInfoPtr_set_SourceSpot_Private_set_Void_GuideMapSpot_0;

			// Token: 0x0400ADAD RID: 44461
			private static readonly IntPtr NativeMethodInfoPtr_get_TargetSpot_Public_get_GuideMapSpot_0;

			// Token: 0x0400ADAE RID: 44462
			private static readonly IntPtr NativeMethodInfoPtr_set_TargetSpot_Private_set_Void_GuideMapSpot_0;

			// Token: 0x0400ADAF RID: 44463
			private static readonly IntPtr NativeMethodInfoPtr_get_PathVisual_Public_get_Image_0;

			// Token: 0x0400ADB0 RID: 44464
			private static readonly IntPtr NativeMethodInfoPtr_set_PathVisual_Private_set_Void_Image_0;

			// Token: 0x0400ADB1 RID: 44465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000F73 RID: 3955
		[ObfuscatedName("Common.UI.GlobalMap.GuideMapController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060112CD RID: 70349 RVA: 0x003F5CCC File Offset: 0x003F3ECC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr);
				GuideMapController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, "<>9");
				GuideMapController.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, "<>9__8_0");
				GuideMapController.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, "<>9__8_1");
				GuideMapController.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, "<>9__17_0");
				GuideMapController.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, "<>9__17_1");
				GuideMapController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, 100687330);
				GuideMapController.__c.NativeMethodInfoPtr__Awake_b__8_0_Internal_GuideMapSpot_MapConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, 100687331);
				GuideMapController.__c.NativeMethodInfoPtr__Awake_b__8_1_Internal_GuideMapSpot_MapConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, 100687332);
				GuideMapController.__c.NativeMethodInfoPtr__GetNeighbourDistance_b__17_0_Internal_Boolean_GuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, 100687333);
				GuideMapController.__c.NativeMethodInfoPtr__GetNeighbourDistance_b__17_1_Internal_GuideMapSpot_GuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr, 100687334);
			}

			// Token: 0x060112CE RID: 70350 RVA: 0x003F5DC0 File Offset: 0x003F3FC0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112CF RID: 70351 RVA: 0x003F5DFC File Offset: 0x003F3FFC
			[CallerCount(0)]
			public unsafe GuideMapSpot _Awake_b__8_0(GuideMapController.MapConnection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.__c.NativeMethodInfoPtr__Awake_b__8_0_Internal_GuideMapSpot_MapConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr3) : null;
			}

			// Token: 0x060112D0 RID: 70352 RVA: 0x003F5E4C File Offset: 0x003F404C
			[CallerCount(0)]
			public unsafe GuideMapSpot _Awake_b__8_1(GuideMapController.MapConnection x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.__c.NativeMethodInfoPtr__Awake_b__8_1_Internal_GuideMapSpot_MapConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr3) : null;
			}

			// Token: 0x060112D1 RID: 70353 RVA: 0x003F5E9C File Offset: 0x003F409C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290869, XrefRangeEnd = 290871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetNeighbourDistance_b__17_0(GuideMapSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.__c.NativeMethodInfoPtr__GetNeighbourDistance_b__17_0_Internal_Boolean_GuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060112D2 RID: 70354 RVA: 0x003F5EEC File Offset: 0x003F40EC
			[CallerCount(0)]
			public unsafe GuideMapSpot _GetNeighbourDistance_b__17_1(GuideMapSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.__c.NativeMethodInfoPtr__GetNeighbourDistance_b__17_1_Internal_GuideMapSpot_GuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr3) : null;
			}

			// Token: 0x060112D3 RID: 70355 RVA: 0x00095562 File Offset: 0x00093762
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005945 RID: 22853
			// (get) Token: 0x060112D4 RID: 70356 RVA: 0x003F5F3C File Offset: 0x003F413C
			// (set) Token: 0x060112D5 RID: 70357 RVA: 0x0009556B File Offset: 0x0009376B
			public unsafe static GuideMapController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005946 RID: 22854
			// (get) Token: 0x060112D6 RID: 70358 RVA: 0x003F5F64 File Offset: 0x003F4164
			// (set) Token: 0x060112D7 RID: 70359 RVA: 0x0009557D File Offset: 0x0009377D
			public unsafe static Func<GuideMapController.MapConnection, GuideMapSpot> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapController.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuideMapController.MapConnection, GuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapController.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005947 RID: 22855
			// (get) Token: 0x060112D8 RID: 70360 RVA: 0x003F5F8C File Offset: 0x003F418C
			// (set) Token: 0x060112D9 RID: 70361 RVA: 0x0009558F File Offset: 0x0009378F
			public unsafe static Func<GuideMapController.MapConnection, GuideMapSpot> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapController.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuideMapController.MapConnection, GuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapController.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005948 RID: 22856
			// (get) Token: 0x060112DA RID: 70362 RVA: 0x003F5FB4 File Offset: 0x003F41B4
			// (set) Token: 0x060112DB RID: 70363 RVA: 0x000955A1 File Offset: 0x000937A1
			public unsafe static Func<GuideMapSpot, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapController.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuideMapSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapController.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005949 RID: 22857
			// (get) Token: 0x060112DC RID: 70364 RVA: 0x003F5FDC File Offset: 0x003F41DC
			// (set) Token: 0x060112DD RID: 70365 RVA: 0x000955B3 File Offset: 0x000937B3
			public unsafe static Func<GuideMapSpot, GuideMapSpot> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapController.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuideMapSpot, GuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapController.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADB2 RID: 44466
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400ADB3 RID: 44467
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400ADB4 RID: 44468
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400ADB5 RID: 44469
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400ADB6 RID: 44470
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x0400ADB7 RID: 44471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADB8 RID: 44472
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__8_0_Internal_GuideMapSpot_MapConnection_0;

			// Token: 0x0400ADB9 RID: 44473
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__8_1_Internal_GuideMapSpot_MapConnection_0;

			// Token: 0x0400ADBA RID: 44474
			private static readonly IntPtr NativeMethodInfoPtr__GetNeighbourDistance_b__17_0_Internal_Boolean_GuideMapSpot_0;

			// Token: 0x0400ADBB RID: 44475
			private static readonly IntPtr NativeMethodInfoPtr__GetNeighbourDistance_b__17_1_Internal_GuideMapSpot_GuideMapSpot_0;
		}

		// Token: 0x02000F74 RID: 3956
		[ObfuscatedName("Common.UI.GlobalMap.GuideMapController+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x060112DE RID: 70366 RVA: 0x003F6004 File Offset: 0x003F4204
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GuideMapController.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuideMapController>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapController.__c__DisplayClass17_0>.NativeClassPtr);
				GuideMapController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				GuideMapController.__c__DisplayClass17_0.NativeFieldInfoPtr_guideMapSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapController.__c__DisplayClass17_0>.NativeClassPtr, "guideMapSpot");
				GuideMapController.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.__c__DisplayClass17_0>.NativeClassPtr, 100687335);
				GuideMapController.__c__DisplayClass17_0.NativeMethodInfoPtr__GetNeighbourDistance_b__2_Internal_Int32_GuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapController.__c__DisplayClass17_0>.NativeClassPtr, 100687336);
			}

			// Token: 0x060112DF RID: 70367 RVA: 0x003F6080 File Offset: 0x003F4280
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapController.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112E0 RID: 70368 RVA: 0x003F60BC File Offset: 0x003F42BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290871, XrefRangeEnd = 290873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetNeighbourDistance_b__2(GuideMapSpot spot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapController.__c__DisplayClass17_0.NativeMethodInfoPtr__GetNeighbourDistance_b__2_Internal_Int32_GuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060112E1 RID: 70369 RVA: 0x000955C5 File Offset: 0x000937C5
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700594A RID: 22858
			// (get) Token: 0x060112E2 RID: 70370 RVA: 0x003F610C File Offset: 0x003F430C
			// (set) Token: 0x060112E3 RID: 70371 RVA: 0x000955CE File Offset: 0x000937CE
			public unsafe GuideMapController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700594B RID: 22859
			// (get) Token: 0x060112E4 RID: 70372 RVA: 0x003F613C File Offset: 0x003F433C
			// (set) Token: 0x060112E5 RID: 70373 RVA: 0x000955ED File Offset: 0x000937ED
			public unsafe IGuideMapSpot guideMapSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.__c__DisplayClass17_0.NativeFieldInfoPtr_guideMapSpot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapController.__c__DisplayClass17_0.NativeFieldInfoPtr_guideMapSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADBC RID: 44476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ADBD RID: 44477
			private static readonly IntPtr NativeFieldInfoPtr_guideMapSpot;

			// Token: 0x0400ADBE RID: 44478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADBF RID: 44479
			private static readonly IntPtr NativeMethodInfoPtr__GetNeighbourDistance_b__2_Internal_Int32_GuideMapSpot_0;
		}
	}
}
